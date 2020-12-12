using MiniHTTPServer.HTTP.Enums;
using MiniHTTPServer.HTTP.Headers;
using MiniHTTPServer.HTTP.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniHTTPServer.WebServer.Results
{
    public class RedirectResult : HttpResponse
    {
        public RedirectResult(string location)
            :base(HttpResponseStatusCode.SeeOther)
        {
            this.AddHeader(new HttpHeader("Location", location));
        }
    }
}
