using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mr_Murphy_TenetsOfOOP
{
    internal abstract class Shape
    {
        public  Shape()
        {

        }
        public Shape(string name, int NumberOfSides, ConsoleColor colour)
        {

        }
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public void SetColour(ConsoleColor colour)
        {
            Colour = colour;
        }

        public string Name { get; set; }
        public double Perimeter { get; set; }
        public double Area { get; set; }
        public int NumberOfSides { get; set; }
        public ConsoleColor Colour { get; set; }
    }
}
