using System;

namespace GeometricFigureLib
{
    public class Circle : IFigure
    {
        private readonly double _radius;
        
        public Circle(double radius)
        {
            _radius = radius;
        }
        
        public double CalculateArea()
        {
            return Math.Pow(_radius, 2) * Math.PI;
        }
        
        public override bool Equals(object? obj)
        {
            var t = (Circle)obj;
            return t != null && t._radius.Equals(_radius);
        }

        protected bool Equals(Circle other)
        {
            return _radius.Equals(other._radius);
        }

        public override int GetHashCode()
        {
            return _radius.GetHashCode();
        }
    }
}