using System;

namespace Shape
{
    public class Circle : IDrawable
    {
        private int radius;
        public int Radius
        {
            get { return this.radius; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Radius must be at least 1");
                }
                this.radius = value;
            }
        }
        public Circle(int radius)
        {
            this.Radius = radius;
        }
        public void Draw()
        {
            double r_in = this.Radius - 0.4;
            double r_out = this.Radius + 0.4;
            for (double y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < r_out; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= r_in * r_in && value <= r_out * r_out)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                    Console.WriteLine();
            }
        }
    }
}