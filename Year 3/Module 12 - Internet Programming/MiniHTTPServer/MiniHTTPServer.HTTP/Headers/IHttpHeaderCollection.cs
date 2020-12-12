using System;
using System.Collections.Generic;
using System.Text;

namespace MiniHTTPServer.HTTP.Headers
{
    public interface IHttpHeaderCollection
    {
        void AddHeader(HttpHeader header);
        bool ContainsHeader(string key);
        HttpHeader GetHeader(string key);
        void Add(HttpHeader header);
    }
}
