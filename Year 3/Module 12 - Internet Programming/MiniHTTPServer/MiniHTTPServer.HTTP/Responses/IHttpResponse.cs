using MiniHTTPServer.HTTP.Enums;
using MiniHTTPServer.HTTP.Headers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniHTTPServer.HTTP.Responses
{
    interface IHttpResponse
    {
        HttpResponseStatusCode StatusCode { get; set; }
        IHttpHeaderCollection Headers { get; }
        byte[] Content { get; set; }
        void AddHeader(HttpHeader header);
        byte[] GetBytes();
    }
}
