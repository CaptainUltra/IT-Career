using System;
using System.Collections.Generic;
using System.Text;

namespace MiniHTTPServer.IRunes.Models
{
    public class Album
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Cover { get; private set; }
        public decimal Price { get; private set; }
    }
}
