using GFramework.Network;
using Share.Protocols;

namespace GameServer
{
    public class TickAgent : Singleton<TickAgent>
    {
        public Dictionary<ulong, BattleRoom> roomMap = new Dictionary<ulong, BattleRoom>();
        public BattleRoom CreateRoom(ulong roomID)
        {
            if (this.roomMap == null) this.roomMap = new Dictionary<ulong, BattleRoom>();
            if (this.roomMap.ContainsKey(roomID)) return this.roomMap[roomID];
            BattleRoom battleRoom = new BattleRoom(roomID);
            this.roomMap[roomID] = battleRoom;
            return battleRoom;
        }

        public void TickUpdate(ulong roomID, TickUpdateData data)
        {
            roomMap[roomID].CollectNextData<TickUpdateData>(data);
        }
    }
}
