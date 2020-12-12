using MiniHTTPServer.HTTP.Enums;
using MiniHTTPServer.WebServer;
using MiniHTTPServer.WebServer.Routing;
using System;

namespace MiniHTTPServer.Demo
{
    class Launcher
    {
        static void Main(string[] args)
        {
            IServerRoutingTable serverRoutingTable = new ServerRoutingTable();

            serverRoutingTable.Add(
                HttpRequestMethod.Get,
                "/",
                request => new HomeController().Index(request));

            Server server = new Server(8000, serverRoutingTable);

            server.Run();
        }
    }
}
