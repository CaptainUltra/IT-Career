namespace Figures
{
    public class Square : Shape
    {
        private double side;
        public Square(double side)
        {
            this.Side = side;
        }
        public override double CalculateArea()
        {
            var area = this.Side * this.Side;
            return area;
        }
        public override double CalculatePerimeter()
        {
            var perimeter = 4 * this.Side;
            return perimeter;
        }
        public double Side { get; set; }
    }
    
}
