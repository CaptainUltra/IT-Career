using System;

namespace LabExercise
{
    static class Geometry
    {
        static double SquarePerimeter(double side)
        {
            return 4*side;
        }
        static double SquareArea(double side)
        {
            return side*side;
        }
        static double ReactanglePerimeter(double a, double b)
        {
            return 2*(a+b);
        }
        static double RectangleArea(double a, double b)
        {
            return a*b;
        }
        static double CircleArea(double r)
        {
            return Math.PI*Math.Pow(r,2);
        }
    }
}