using System;
using System.Collections.Generic;
using System.Text;

namespace MiniHTTPServer.HTTP.Headers
{
    class HttpHeaderCollection : IHttpHeaderCollection
    {
        private Dictionary<string, HttpHeader> headers;
        public HttpHeaderCollection()
        {
            this.headers = new Dictionary<string, HttpHeader>();
        }

        public void AddHeader(HttpHeader header)
        {
            this.headers.Add(header.Key, header);
        }

        public bool ContainsHeader(string key)
        {
            return headers.ContainsKey(key);
        }

        public HttpHeader GetHeader(string key)
        {
            return this.headers[key];
        }
        public override string ToString()
        {
            return String.Join("/r/n", this.headers.Values);
        }
    }
}
