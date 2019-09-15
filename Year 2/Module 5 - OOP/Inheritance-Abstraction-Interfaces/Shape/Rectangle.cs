using System;

namespace Shape
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;
        public int Width
        {
            get { return this.width; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Width must be at least 1");
                }
                this.width = value;
            }
        }
        public int Height
        {
            get { return this.height; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Height must be at least 1");
                }
                this.height = value;
            }
        }
        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public void Draw()
        {
            System.Console.WriteLine(new string('*', Width));
            for (int i = 0; i < Height - 2; i++)
            {
                System.Console.WriteLine($"*{new string(' ', Width - 2)}*");
            }
            System.Console.WriteLine(new string('*', Width));
        }
    }
}