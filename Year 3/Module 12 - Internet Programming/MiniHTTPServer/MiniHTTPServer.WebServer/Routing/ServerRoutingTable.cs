using MiniHTTPServer.HTTP.Enums;
using MiniHTTPServer.HTTP.Requests;
using MiniHTTPServer.HTTP.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniHTTPServer.WebServer.Routing
{
    public class ServerRoutingTable : IServerRoutingTable
    {
        private Dictionary<HttpRequestMethod, Dictionary<string, Func<IHttpRequest, IHttpResponse>>> routes;
        public ServerRoutingTable()
        {
            this.routes = new Dictionary<HttpRequestMethod, Dictionary<string, Func<IHttpRequest, IHttpResponse>>>
            {
                [HttpRequestMethod.Get] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>(),
                [HttpRequestMethod.Post] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>(),
                [HttpRequestMethod.Put] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>(),
                [HttpRequestMethod.Delete] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>()
            };
        }
        public void Add(HttpRequestMethod requestMethod, string path, Func<IHttpRequest, IHttpResponse> func)
        {
            this.routes[requestMethod][path] = func;
        }

        public bool Contains(HttpRequestMethod requestMethod, string path)
        {
            return this.routes.ContainsKey(requestMethod) && this.routes[requestMethod].ContainsKey(path);
        }

        public Func<IHttpRequest, IHttpResponse> Get(HttpRequestMethod requestMethod, string path)
        {
            return this.routes[requestMethod][path];
        }
    }
}
