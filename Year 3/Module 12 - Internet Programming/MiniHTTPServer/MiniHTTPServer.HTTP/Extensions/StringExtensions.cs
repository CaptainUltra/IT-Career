using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniHTTPServer.HTTP.Extensions
{
    public static class StringExtensions
    {
        public static string Capitalize(this string obj)
        {
            var firstChar = obj[0];
            var remainingStr = obj.Substring(1);

            var result = char.ToUpper(firstChar) + remainingStr.ToLower();
            return result;
        }
    }
}
