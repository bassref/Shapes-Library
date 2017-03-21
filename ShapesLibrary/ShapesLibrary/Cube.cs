// Name: Rephael Edwards
//File: Cube.cs
// Description: The cube class. 
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Cube : ShapeBase, Interface3DShapes
    {
        private double x1, x2, y1, y2, width, length, height;
        public Cube()
        {
            x1 = x2 = y1 = width = height = length = 0;
        }

        public Cube(double xTemp, double yTemp, double zTemp, string nameT)
            : base(xTemp, yTemp, zTemp, nameT)
        {
            x1 = xTemp;
            x2 = xTemp;
            y1 = yTemp;
            width = 0;
            length = 0;
            height = 0;
            Name = "cube";
        }
        
        public double CalculatedLength()
        {
            length = (x2 - x1);
            if ((length < 0) |(height < 0))
                throw new NegativeNumberException();
            else
                return length;  
        }
        // function to calculate surface area
        public double CalculatedSurfaceArea()
        {
            return  Math.Round(6 * (Math.Pow(length, 2)));
        }

        // function to calculate volume
        public double CalculatedVolume()
        {
            return  Math.Round(Math.Pow((x2 - x1), 3));
        }

        public override string ToString()
        {
            return "Shape Name: " + Name + "\nLength  = " + CalculatedLength() 
                + "\n Width = " + CalculatedLength()
                + " \nHeight = " + CalculatedLength() 
                + "\nThe total surface area = " + CalculatedSurfaceArea()
                + "\nThe volume = " + CalculatedVolume();
        }
    }
}
