﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MiniHTTPServer.HTTP.Exceptions
{
    public class BadRequestException : Exception
    {
        private static string DefaultMessage = "The Request was malformed or contains unsupported elements.";
        public BadRequestException() : base(DefaultMessage)
        { }
        public BadRequestException(string message) : base(message)
        { }
    }
}
