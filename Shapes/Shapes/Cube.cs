using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Cube : ShapeBase, Interface3DShapes
    {
        private double x1, x2, y1, y2; 
         public Cube()
        {
            x1 = x2 = y1 = 0;
        }

         public Cube(double tempRadius, double xTemp, double yTemp, double zTemp, string nameT)
            :base(xTemp, yTemp, zTemp, nameT)
        {
            x1 = xTemp;
            x2 = xTemp;
            y1 = yTemp;
        }
        // function to calculate surface area
         public double CalculatedSurfaceArea()
         {
             return 6 * ((x2 - x1) * (x2 - y1));
         }

        // function to calculate volume
         public double CalculatedVolume()
        {
            return Math.Pow((x2 - x1), 3);
        }
    }
}
