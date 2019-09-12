using System;

namespace UniverasalScale
{
    class Program
    {
        static void Main(string[] args)
        {
            var scale =  new Scale<string>("Gosho", "Pesho");
            System.Console.WriteLine(scale.GetHeavier());
        }
    }
}
