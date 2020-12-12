using MiniHTTPServer.HTTP.Enums;
using MiniHTTPServer.HTTP.Headers;
using MiniHTTPServer.HTTP.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniHTTPServer.WebServer.Results
{
    public class TextResult : HttpResponse
    {
        public TextResult(string content, HttpResponseStatusCode responseStatusCode, string contentType = "text/plain; charset=UTF-8")
            :base(responseStatusCode)
        {
            this.AddHeader(new HttpHeader("Content-Type", contentType));
            this.Content = Encoding.UTF8.GetBytes(content);
        }
        public TextResult(byte[] content, HttpResponseStatusCode responseStatusCode, string contentType = "text/plain; charset=UTF-8")
            : base(responseStatusCode)
        {
            this.AddHeader(new HttpHeader("Content-Type", contentType));
            this.Content = content;
        }
    }
}
