using System.Net.Sockets;
using System.Net;
using GFramework;
using GFramework.Network;
using Share.Protocols;

namespace GameServer
{
    public class LogicDispatcher : ADispatcher
    {
        GLogger logger = new GLogger("LogicDispatcher");

        public override void DecodeForm(ProtoDefine define, byte[] data)
        {
            logger.P($"反序列化{define}类型消息...");
            switch (define)
            {
                case ProtoDefine.C2S_Login: DealWithLogin(ProtoBufNetSerializer.Decode<LoginReq>(data)); break;
                case ProtoDefine.C2S_Match: DealWithMatch(ProtoBufNetSerializer.Decode<MatchReq>(data)); break;
                case ProtoDefine.S2C_Game_Start: break;

                default:
                    throw new Exception($"没有找到{define}类型协议的定义？？？");
            }
        }

        public void Response<T>(ProtoDefine define, T resp)
        {
            if (channel == null) return;
            byte[] data = ProtoBufNetSerializer.Encode<T>(resp);
            this.channel.Send(define, data);
        }

        public override void RegisterMsg(RpcCallBack response)
        {

        }

        private void DealWithLogin(LoginReq loginReq)
        {
            logger.P($"处理登录消息：{loginReq}...");
            Response<LoginResp>(ProtoDefine.C2S_Login, new LoginResp(1, "xzjH5263@163.com", "crying cat"));
        }

        private void DealWithMatch(MatchReq matchReq)
        {
            logger.P($"处理加入房间消息：{matchReq}...");
            BattleRoom battleRoom = null;
            if (TickAgent.Instance.roomMap.Count > 0)
            {
                battleRoom = TickAgent.Instance.roomMap.First().Value;
            }
            else
            {
                battleRoom = TickAgent.Instance.CreateRoom(matchReq.netID);
            }
            IPEndPoint iPEndPoint = new IPEndPoint(this.channel.iPEndPoint.Address, matchReq.port);
            logger.P($"客户端帧同步端口：{iPEndPoint}");
            UdpClientProxy udpClientProxy = new UdpClientProxy(iPEndPoint, new TickDispatcher(), new ProtoPacker());
            udpClientProxy.Connect(iPEndPoint);
            battleRoom.AddPlayer(this.channel as TcpClientProxy, udpClientProxy, matchReq.netID);
            Response<MatchResp>(ProtoDefine.C2S_Match, new MatchResp(1, battleRoom.roomID, matchReq.netID, battleRoom.playerNum));
            if (battleRoom.playerNum >= 1)
            {
                System.Timers.Timer t = new System.Timers.Timer(3000);//实例化Timer类，设置间隔时间为10000毫秒；
                t.Elapsed += new System.Timers.ElapsedEventHandler((source, e) =>
                {
                    battleRoom.GameBegin();
                });//到达时间的时候执行事件；
                t.AutoReset = false;//设置是执行一次（false）还是一直执行(true)；
                t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；
                t.Start(); //启动定时器
            }
        }

    }
}
