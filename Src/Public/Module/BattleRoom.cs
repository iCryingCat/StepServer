using System.Net;
using GFramework;
using GFramework.Network;

using Share.Protocols;

namespace GameServer
{
    public class BattleRoom
    {
        GLogger logger = new GLogger("BattleRoom");

        public ulong roomID { get; }
        public int playerNum { get; private set; }
        // 玩家tcp索引
        private Dictionary<ulong, TcpClientProxy> tcpPlayersMap = new Dictionary<ulong, TcpClientProxy>();
        // 玩家udp索引
        private Dictionary<ulong, UdpClientProxy> udpPlayersMap = new Dictionary<ulong, UdpClientProxy>();
        // <帧id，<玩家id，帧数据>>
        private Dictionary<ulong, Dictionary<IPEndPoint, TickUpdateData>> tickDatas = new Dictionary<ulong, Dictionary<IPEndPoint, TickUpdateData>>();
        // 下一帧数据
        private Dictionary<ulong, TickUpdateData> nextFrameData = new Dictionary<ulong, TickUpdateData>();

        public BattleRoom(ulong roomID)
        {
            this.roomID = roomID;
        }

        public void AddPlayer(TcpClientProxy tcpClientProxy, UdpClientProxy udpClientProxy, ulong netID)
        {
            if (this.udpPlayersMap == null) this.udpPlayersMap = new Dictionary<ulong, UdpClientProxy>();
            this.SynToAll(ProtoDefine.S2C_OtherJoinRoom, new JoinRoomResp(roomID, netID), netID);
            this.tcpPlayersMap[netID] = tcpClientProxy;
            this.udpPlayersMap[netID] = udpClientProxy;
            this.playerNum = this.tcpPlayersMap.Count;
        }

        public void GameBegin()
        {
            SynToAll<AckResp>(ProtoDefine.S2C_Game_Start, new AckResp(1));
            Thread tickThread = new Thread(TickBroadcast);
            tickThread.Start();
        }

        public void SynToAll<T>(ProtoDefine define, T data, ulong netID = 0)
        {
            ulong[] players = this.tcpPlayersMap.Keys.ToArray();
            int playersNum = players.Length;
            for (int i = 0; i < playersNum; ++i)
            {
                if (netID == players[i]) continue;
                this.tcpPlayersMap[players[i]].Send(define, ProtoBufNetSerializer.Encode<T>(data));
            }
        }

        public void CollectNextData<T>(TickUpdateData data)
        {
            if (this.nextFrameData == null) this.nextFrameData = new Dictionary<ulong, TickUpdateData>();
            this.nextFrameData[data.netID] = data;
        }

        public void TickBroadcast()
        {
            while (true)
            {
                TickUpdateDataList dataList = new TickUpdateDataList(this.nextFrameData.Values.ToList());
                UdpClientProxy[] allPlayers = udpPlayersMap.Values.ToArray();
                for (int i = 0; i < allPlayers.Length; i++)
                {
                    byte[] data = ProtoBufNetSerializer.Encode<TickUpdateDataList>(dataList);
                    allPlayers[i].Send(ProtoDefine.S2C_Tick_Update, data);
                }
                Thread.Sleep(50);
            }
        }
    }
}
