using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_500W_5_GeometricalShape
{
    internal class Triangle : Shape
    {
        public double _height;
        public double _width;

        public Triangle(double height, double width)
        {
            _height = height;
            _width = width;
        }
        /// <summary> </summary>
        /// <returns> area of the triangle </returns>
        public override double CalculateSurface()
        {
            return _height * _width / 2;
        }
    }
}
