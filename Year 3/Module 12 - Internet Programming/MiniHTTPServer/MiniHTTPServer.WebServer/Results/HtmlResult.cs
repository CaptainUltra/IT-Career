using MiniHTTPServer.HTTP.Enums;
using MiniHTTPServer.HTTP.Headers;
using MiniHTTPServer.HTTP.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniHTTPServer.WebServer.Results
{
    public class HtmlResult : HttpResponse
    {
        public HtmlResult(string content, HttpResponseStatusCode responseStatusCode)
            :base(responseStatusCode)
        {
            this.AddHeader(new HttpHeader("Content-Type", "text/html; charset=UTF-8"));
            this.Content = Encoding.UTF8.GetBytes(content);
        }
    }
}
