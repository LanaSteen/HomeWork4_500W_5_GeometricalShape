using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
5. Define an abstract class Shape with abstract method CalculateSurface()
and fields width and height. 

Define two additional classes for a triangle
and a rectangle, which implement CalculateSurface(). This method has
to return the areas of the rectangle (height*width) and the triangle
(height*width/2). 

Define a class for a circle with an appropriate
constructor, which initializes the two fields (height and width) with the
same value (the radius) and implement the abstract method for calculating
the area. 


Create an array of different shapes and calculate the area of each
shape in another array.*/
namespace HomeWork4_500W_5_GeometricalShape
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] arrOfCircle = new double[5];
            for (int i = 0; i <= 4; i++)
            {
                Random random0 = new Random();
                Circle circle = new Circle(random0.NextDouble(), random0.NextDouble());
                arrOfCircle[i] = circle.CalculateSurface();
                Console.WriteLine(arrOfCircle[i]);
            }
      
            //////
            double[] arrOfTriangle = new double[5];
            for (int i = 0; i <= 4; i++)
            {
                Random random0 = new Random();
                Random random00 = new Random();
                Triangle triangle = new Triangle(random0.NextDouble(), random00.NextDouble());
                arrOfTriangle[i] = triangle.CalculateSurface();
                Console.WriteLine(arrOfTriangle[i]);
            }
         
            //////
            double[] arrOfRectangle = new double[5];
            for (int i = 0; i <= 4; i++)
            {
                Random random0 = new Random();
                Random random00 = new Random();
                Rectangle rectangle = new Rectangle(random0.NextDouble(), random00.NextDouble());
                arrOfRectangle[i] = rectangle.CalculateSurface();
                Console.WriteLine(arrOfRectangle[i]);
            }
  

            Console.ReadLine();
        }
    }
}


//random არ მუშაობს სწორად 