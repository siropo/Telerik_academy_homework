using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeScore;

namespace _01.ShapeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = 
            {
                new Circle(10), 
                new Rectangle(4, 6), 
                new Triangle(11,23),
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
