namespace Figures
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double CalculateArea()
        {
            var area = this.Width * this.Height;
            return area;
        }
        public override double CalculatePerimeter()
        {
            var perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }
        public double Width { get; set; }
        public double Height { get; set; }
    }
    
}
