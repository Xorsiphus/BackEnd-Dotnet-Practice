using System;
using System.Collections.Generic;
using System.Linq;

namespace GeometricFigureLib
{
    public class Triangle : IFigure
    {
        private readonly List<double> _sides = new List<double>();
        
        public Triangle(double a, double b, double c)
        {
            if (a + b < c || a + c < b || b + c < a)
                throw new Exception("The figure is not a triangle!");
            _sides.Add(a);
            _sides.Add(b);
            _sides.Add(c);
        }
        
        public double CalculateArea()
        {
            var p = _sides.Sum() / 2;
            return p * _sides.Aggregate((cur, side) => cur * (p - side));
        }

        public bool IsRight()
        {
            var powA = _sides[0] * _sides[0];
            var powB = _sides[1] * _sides[1];
            var powC = _sides[2] * _sides[2];

            return Math.Abs(powA + powB - powC) < 0.0000001 ||
                   Math.Abs(powA + powC - powB) < 0.0000001 ||
                   Math.Abs(powC + powB - powA) < 0.0000001;
        }
        
        public override bool Equals(object obj)
        {
            var t = (Triangle)obj;
            return t != null && t._sides.SequenceEqual(_sides);
        }

        protected bool Equals(Triangle other)
        {
            return Equals(_sides, other._sides);
        }

        public override int GetHashCode()
        {
            return (_sides != null ? _sides.GetHashCode() : 0);
        }
    }
}