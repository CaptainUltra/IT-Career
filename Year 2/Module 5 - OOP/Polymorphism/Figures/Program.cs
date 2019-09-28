using System.Collections.Generic;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figures = new List<Shape>();
            figures.Add(new Square(4));
            figures.Add(new Circle(4));

            foreach (var figure in figures)
            {
                var area = figure.CalculateArea();
                var perimeter = figure.CalculatePerimeter();
                var figureType = figure.GetType().Name;

                System.Console.WriteLine($"I am a {figureType}");
                System.Console.WriteLine($"Perimeter: {perimeter:F2}");
                System.Console.WriteLine($"Area: {area:F2}");
            }
        }
    }
}
