// Name: Rephael Edwards
// File: ShapeBase.cs
// Description: The sphere class.
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Sphere : ShapeBase, Interface3DShapes
    {
        private double radius;
        private double x, y;

        public Sphere()
        {
            radius = 0;
        }

        public Sphere(double tempRadius, double xTemp, double yTemp, double zTemp, string nameT)
            : base(xTemp, yTemp, zTemp, nameT)
        {
            if (tempRadius < 0)
                throw new NegativeNumberException();
            else
            {
                radius = tempRadius;
                x = xTemp;
                y = yTemp;
                Name = "sphere";
            }
        }
        // function to calculate surface area
        public double CalculatedSurfaceArea()
        {
            return Math.Round((4 * Math.PI * Math.Pow(radius, 2)));
        }
        
        // function to calculate volume
        public double CalculatedVolume()
        {
            return Math.Round(((4 / 3) * Math.PI * Math.Pow(radius, 3)));
        }

        public override string ToString()
        {
            return "Shape Name: " + Name + "\nCenter  = ( " + x + " , " + y + " ) \nThe radius = " +
                radius + "\nThe total surface area = " + CalculatedSurfaceArea()
                + "\nThe volume = " + CalculatedVolume();
        }
    }
}
