using System.Linq;

namespace Telephony
{
    public class Smartphone : IBrowsable, ICallable
    {
        public void Browse(string url)
        {
            if(url.Any(x => char.IsDigit(x)))
            {
                System.Console.WriteLine($"Invalid URL!");
            }
            else
            {
                System.Console.WriteLine($"Browsing: {url}");
            }
        }

        public void Call(string number)
        {
            if(number.All(x => char.IsDigit(x)))
            {
                System.Console.WriteLine($"Calling... {number}");
            }
            else
            {
                System.Console.WriteLine($"Invalid number!");
            }
        }
    }
}