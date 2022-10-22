using System.Net;

using GFramework.Network;

using Share.Services;

namespace GameServer
{
    public class LogicService : Singleton<LogicService>, ILogic2Hall
    {
        public void OnOtherJoinRoom(IPEndPoint iPEndPoint, ulong roomID)
        {
            // ServerManager.tickAgent.roomMap[roomID].AddPlayer(, new UdpClientProxy(iPEndPoint, new LogicDispatcher(), new ProtoPacker()));
        }
    }
}
