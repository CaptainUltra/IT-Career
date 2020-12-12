using MiniHTTPServer.HTTP.Enums;
using MiniHTTPServer.HTTP.Requests;
using MiniHTTPServer.HTTP.Responses;
using MiniHTTPServer.WebServer.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniHTTPServer.Demo
{
    public class HomeController
    {
        public IHttpResponse Index(IHttpRequest request)
        {
            string content = "<h1> This is a test page. Server is working.</h1>";

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }
    }
}
