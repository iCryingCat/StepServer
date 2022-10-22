using GameServer;

using GFramework;

public class ServerSetup
{
    GLogger logger = new GLogger("ServerSetup");

    public static void Main(string[] args)
    {
        ServerManager server = new ServerManager();
        server.Start();
    }
}