using MiniHTTPServer.HTTP.Requests;
using MiniHTTPServer.HTTP.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniHTTPServer.IRunes.Controllers
{
    public class AlbumsController : BaseController
    {
        public IHttpResponse Create(IHttpRequest httpRequest)
        {
            return this.View();
        }
        public IHttpResponse CreateConfirm(IHttpRequest httpRequest)
        {
            return this.View();
        }
    }
}
