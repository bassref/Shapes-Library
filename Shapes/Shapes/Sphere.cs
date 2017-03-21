using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Sphere : ShapeBase, Interface3DShapes
    {
         private double radius;
         public Sphere()
        {
            radius = 0;
        }

         public Sphere(double tempRadius, double xTemp, double yTemp, double zTemp, string nameT)
            :base(xTemp, yTemp, zTemp, nameT)
        {
            radius = tempRadius;
        }
        // function to calculate surface area
         public double CalculatedSurfaceArea()
         {
             return (4 * Math.PI * Math.Pow(radius, 2));
         }

        // function to calculate volume
         public double CalculatedVolume()
        {
            return ((4/3) * Math.PI * Math.Pow(radius, 3));
        }
    }
}
