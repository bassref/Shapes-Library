// Name: Rephael Edwards
//File: Cylinder.cs
// Description: The cylinder class.
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Cylinder : ShapeBase, Interface3DShapes
    {
        private double radius;
        private double height;
        public Cylinder()
        {
            radius = 0;
            height = 0;
        }

        public Cylinder(double tempRadius, double xTemp, double yTemp, double enteredHeight, string nameT)
            : base(xTemp, yTemp, enteredHeight, nameT)
        {
            if ((tempRadius < 0) |(enteredHeight < 0))
                throw new NegativeNumberException();
            else
            {
                radius = tempRadius;
                height = enteredHeight;
                Name = "cylinder";
            }

        }
        
        // function to calculate surface area
        public double CalculatedSurfaceArea()
        {
            return  Math.Round((2 * Math.PI * radius * height) + (2 * Math.PI * Math.Pow(radius, 2)));
        }

        // function to calculate volume
        public double CalculatedVolume()
        {
            return  Math.Round((Math.PI * Math.Pow(radius, 2) * height));
        }

        public override string ToString()
        {
            return "Shape Name: " + Name + "\n Height  = " +
                height + "\n Radius = " + radius 
                +  "\nThe total surface area = " + CalculatedSurfaceArea()
                + "\nThe volume = " + CalculatedVolume();
        }
    }
}
