using MiniHTTPServer.HTTP.Enums;
using MiniHTTPServer.HTTP.Requests;
using MiniHTTPServer.HTTP.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniHTTPServer.WebServer.Routing
{
    public interface IServerRoutingTable
    {
        void Add(HttpRequestMethod requestMethod, string path, Func<IHttpRequest, IHttpResponse> func);
        bool Contains(HttpRequestMethod requestMethod, string path);
        Func<IHttpRequest, IHttpResponse> Get(HttpRequestMethod requestMethod, string path);
    }
}
