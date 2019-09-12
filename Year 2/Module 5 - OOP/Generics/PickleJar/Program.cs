using System;
class Program
{
    static void Main(string[] args)
    {
        var jar = new CucumberJar();
        jar.Add(new Cucumber());
        jar.Add(new Pickle());

        var jar2 = new PickleJar();
        //jar2.Add(new Cucumber());
        jar2.Add(new Pickle());
        foreach (var item in jar)
        {
            System.Console.WriteLine();
        }
    }
}
