using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Cylinder : ShapeBase, Interface3DShapes
    {
        private double radius;
        private double height;
         public Cylinder()
        {
            radius = 0;
            height = 0;
        }

         public Cylinder(double tempRadius, double xTemp, double yTemp, double zTemp, string nameT)
            :base(xTemp, yTemp, zTemp, nameT)
        {
            radius = tempRadius;
            height = zTemp;

        }
        // function to calculate surface area
         public double CalculatedSurfaceArea()
         {
             return (2 * Math.PI * radius * height) + (2 * Math.PI * Math.Pow(radius, 2));
         }

        // function to calculate volume
         public double CalculatedVolume()
        {
            return (Math.PI * Math.Pow(radius, 2) * height);
        }
    }
}
