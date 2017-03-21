// Name: Rephael Edwards
// File: ShapeBase.cs
// Description: The circle class.
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
   public class Circle : ShapeBase, Interface2DShapes
    {
        private double radius;
        private double x, y;
        
        public Circle()
        {
            radius = 0;
        }

        public Circle(double tempRadius, double xTemp, double yTemp, double zTemp, string nameT)
            : base(xTemp, yTemp, zTemp, nameT)
        {
            if (tempRadius < 0)
                throw new NegativeNumberException();
            else
            {
                radius = tempRadius;
                x = xTemp;
                y = yTemp;
                Name = "circle";
            }
            
        }

        
        //Purpose: overriding the base class function
        //Requires: the radius that will be passed in
        //Returns: the value of the perimeter
        public double CalculatedPerimeter()
        {
            return Math.Round((2 * Math.PI * radius), 1);
        }

        public double CalculatedArea()
        {
            return Math.Round((Math.PI * Math.Pow(radius, 2)), 1);
        }

       // Returns the information on the circle to the output box on the form
        public override string ToString()
        {
            return "Shape Name: " + Name + "\nCenter  = ( " + x + " , " +
                y + " ) \nThe radius = " + radius + "\nThe perimeter = " +
                CalculatedPerimeter() + "\nThe area = " + CalculatedArea();
        }
    }
}
