using System;
using GeometricFigureLib;

namespace LibraryExecutor
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = FigureBuilder.Build(3, 4, 5);
            var circle = FigureBuilder.Build(1);
            Console.WriteLine(triangle.Equals(new Triangle(3, 4, 5)));
            Console.WriteLine(triangle.CalculateArea() + " - " + circle.CalculateArea());
        }
    }
}