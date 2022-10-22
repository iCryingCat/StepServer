using System.Net;

using GFramework;
using GFramework.Network;

namespace GameServer
{
    public class ServerManager
    {
        GLogger logger = new GLogger("ServerManager");

        public void Start()
        {
            var logicIP = new IPEndPoint(IPAddress.Parse("0.0.0.0"), 8888);
            var logicProxy = new TcpServerProxy(logicIP, new LogicDispatcher(), new ProtoPacker());
            logicProxy.Accept();
            logger.P($"登录服务器<{logicIP}>创建成功...");

            var tickIp = new IPEndPoint(IPAddress.Parse("0.0.0.0"), 10086);
            var tickProxy = new UdpServerProxy(tickIp, new TickDispatcher(), new ProtoPacker());
            tickProxy.BeginReceive();
            logger.P($"帧同步服务器{tickIp}创建成功...");

            while (true)
            {
                Thread.Sleep(3000);
            }
        }
    }
}
