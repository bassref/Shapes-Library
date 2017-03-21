// Name: Rephael Edwards
// File: ShapeBase.cs
// Description: The rectangle class.
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Rectangle : ShapeBase, Interface2DShapes
    {
        double x1, x2, y1, y2, length, width;
        public Rectangle()
        {
            x1 = x2 = y1 = y2 = length = width = 0;
        }

        public Rectangle(double xTemp, double yTemp, double zTemp, double otherY, string nameT)
            : base(xTemp, yTemp, zTemp, nameT)
        {
            x1 = xTemp;
            x2 = zTemp;
            y1 = yTemp;
            y2 = otherY;
            length = 0;
            width = 0;
            Name = "rectangle";
        }
        
        public double CalculatedLength()
        {
            length = x2 - x1;
            if (length < 0)
                throw new NegativeNumberException();
            else
               return length;        
        }

        public double CalculatedWidth()
        {
            width = y2 - y1;
            if (width < 0)
                throw new NegativeNumberException();
            else            
                return width;
        }

        //Purpose: overriding the base class function
        //Requires: the radius that will be passed in
        //Returns: the value of the perimeter
        public double CalculatedPerimeter()
        {
            return Math.Round(2 * (CalculatedLength() + CalculatedWidth()));
        }

        public double CalculatedArea()
        {
            return Math.Round(CalculatedLength() * CalculatedWidth());
        }

        public override string ToString()
        {
            return "Shape Name: " + Name + "\nLength  = " + CalculatedLength()
                + "\n Width = Length = " + CalculatedWidth() 
               + "\n The Perimeter = " + CalculatedPerimeter() 
               + "\nThe area = " + CalculatedArea();
        }
    }
}
