using System;
using System.Collections.Generic;
using System.Text;

namespace MiniHTTPServer.HTTP.Exceptions
{
    class InternalServerErrorException : Exception
    {
        private static string DefaultMessage = "The Server has encountered an error.";
        public InternalServerErrorException() : base(DefaultMessage)
        { }
    }
}
