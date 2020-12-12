using MiniHTTPServer.HTTP.Enums;
using MiniHTTPServer.HTTP.Headers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniHTTPServer.HTTP.Requests
{
    public interface IHttpRequest
    {
        string Path { get; }
        string Url { get; }
        Dictionary<string, object> FormData { get; }
        Dictionary<string, object> QueryData { get; }
        IHttpHeaderCollection Headers { get; }
        HttpRequestMethod RequestMethod {get;}
    }
}
