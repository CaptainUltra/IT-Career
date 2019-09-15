using System;

namespace Shape
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var rec = new Rectangle(7, 5);
            rec.Draw();
            var circ = new Circle(10);
            circ.Draw();
        }
    }
}
