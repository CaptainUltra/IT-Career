using System;

namespace Figures
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override double CalculateArea()
        {
            var area = Math.PI *  this.Radius * this.Radius;
            return area;
        }
        public override double CalculatePerimeter()
        {
            var perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }
        public double Radius { get; set; }
    }
    
}
