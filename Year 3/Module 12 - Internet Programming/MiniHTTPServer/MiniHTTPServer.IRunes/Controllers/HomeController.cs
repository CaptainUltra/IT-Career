using MiniHTTPServer.HTTP.Requests;
using MiniHTTPServer.HTTP.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniHTTPServer.IRunes.Controllers
{
    public class HomeController : BaseController
    {
        public IHttpResponse Index(IHttpRequest httpRequest)
        {
            return this.View();
        }
    }
}
