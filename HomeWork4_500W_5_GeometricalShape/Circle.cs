using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_500W_5_GeometricalShape
{
    internal class Circle : Shape
    {
        public double _height;
        public double _width;
        public Circle (double height, double width)
        {
            _height = height;
            _width = width; 
        }
        /// <summary>
        /// gets height and width as equal values and counts that they are the same as the radius
        /// </summary>
        /// <returns> area of the circle </returns>
        public override double CalculateSurface()
        {
            return _height * _width * Math.PI;
        }
    }
}
