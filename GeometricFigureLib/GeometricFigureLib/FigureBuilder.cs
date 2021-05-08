using System;

namespace GeometricFigureLib
{
    public static class FigureBuilder
    {
        public static Circle Build(double a)
        {
            return new Circle(a);
        }
        
        public static Triangle Build(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }
    }
}