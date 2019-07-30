using System;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<string> list = new ArrayList<string>();
            list.Add("ble");
            list.Add("ble");
            list.Add("ble");
            System.Console.WriteLine(list.Count);
            System.Console.WriteLine(list.Capacity());
        }
    }
}
