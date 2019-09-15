using System;

namespace Cars
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Seat seat = new Seat();
            System.Console.WriteLine(seat.Start());//From base class
            System.Console.WriteLine(seat.Stop());

            ICar tesla = new Tesla("3", "Black");
            System.Console.WriteLine(tesla.Start());
            System.Console.WriteLine(tesla.ToString());
            System.Console.WriteLine(tesla.Stop());
            System.Console.WriteLine(tesla.ToString());
        }
    }
}
