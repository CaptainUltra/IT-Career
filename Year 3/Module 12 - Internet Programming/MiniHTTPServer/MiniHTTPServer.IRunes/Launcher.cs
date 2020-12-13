using MiniHTTPServer.HTTP.Enums;
using MiniHTTPServer.IRunes.Controllers;
using MiniHTTPServer.WebServer;
using MiniHTTPServer.WebServer.Results;
using MiniHTTPServer.WebServer.Routing;
using System;

namespace MiniHTTPServer.IRunes
{
    class Launcher
    {
        static void Main(string[] args)
        {
            ServerRoutingTable serverRoutingTable = new ServerRoutingTable();

            serverRoutingTable.Add(HttpRequestMethod.Get, "/", request => new RedirectResult("/Home/Index"));
            serverRoutingTable.Add(HttpRequestMethod.Get, "/Home/Index", request => new HomeController().Index(request));
            serverRoutingTable.Add(HttpRequestMethod.Get, "/Albums/Create", request => new AlbumsController().Create(request));
            serverRoutingTable.Add(HttpRequestMethod.Post, "/Albums/Create", request => new AlbumsController().CreateConfirm(request));

            Server server = new Server(8000, serverRoutingTable);
            server.Run();
        }
    }
}
