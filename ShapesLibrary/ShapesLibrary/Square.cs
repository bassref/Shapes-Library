// Name: Rephael Edwards
// File: ShapeBase.cs
// Description: The square class.
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Square : ShapeBase, Interface2DShapes
    {
        private double x1, x2, y1, y2, length;
        public Square()
        {
            x1 = x2 = y1 = length = 0;
        }

        public Square(double xTemp, double yTemp, double zTemp, string nameT)
            : base(xTemp, yTemp, zTemp, nameT)
        {
            x1 = xTemp;
            x2 = zTemp;
            y1 = yTemp;
            Name = "square";
            length = 0;
        }
        public double CalculatedLength()
        {
            length = (x2 - x1);
            if (length < 0)
                throw new NegativeNumberException();
            else
                return length;   
        }
        
        //Purpose: overriding the base class function
        //Requires: the radius that will be passed in
        //Returns: the value of the perimeter
        public double CalculatedPerimeter()
        {
            return 4 * CalculatedLength();
        }

        public double CalculatedArea()
        {
            return CalculatedLength() * CalculatedLength();
        }

        public override string ToString()
        {
            return "Shape Name: " + Name + "\nLength  = " + CalculatedLength() +
               "\n Width = " + CalculatedLength() + "\n The Perimeter = " + CalculatedPerimeter()
                + "\nThe area = " + CalculatedArea();
        }
    }
}
