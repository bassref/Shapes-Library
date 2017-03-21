using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Cuboid : ShapeBase, Interface3DShapes
    {
        private double x1, x2, y1, y2, width, length, height;
        public Cuboid()
        {
            x1 = x2 = y1 = width = height = length = 0;
        }

        public Cuboid(double xTemp, double yTemp, double enteredWidth, double enteredHeight, string nameT)
            : base(xTemp, yTemp, enteredWidth, nameT)
        {
            x1 = xTemp;
            x2 = yTemp;
            y1 = 0;
            width = enteredWidth;
            length = 0;
            height = enteredHeight;
            Name = "cuboid";
        }
        
        public double CalculatedLength()
        {
            length = (x2 - x1);
            if ((length < 0) |(height < 0) |(width < 0))
                throw new NegativeNumberException();
            else
                return length;  
        }
        // function to calculate surface area
        public double CalculatedSurfaceArea()
        {
            return Math.Round(2 * ((CalculatedLength() * width)
                + (width * height) + (height * CalculatedLength())));
        }

        // function to calculate volume
        public double CalculatedVolume()
        {
            return Math.Round(CalculatedLength() * width * height);
        }

        public override string ToString()
        {
            return "Shape Name: " + Name + "\nLength  = " + CalculatedLength() 
                + "\n Width = " + width
                + " \nHeight = " + height
                + "\nThe total surface area = " + CalculatedSurfaceArea()
                + "\nThe volume = " + CalculatedVolume();
        }
    }
    
}
