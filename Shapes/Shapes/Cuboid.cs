using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Cuboid : ShapeBase, Interface3DShapes
    {
            private double x1, x2, x3, y1, y2, y3, z1, z2, z3;
            public Cuboid()
            {
                x1 = x2 = x3 = y1 = y2 = y3 = z1 = z2 = z3 = 0;
            }

            public Cuboid(double tempRadius, double xTemp, double yTemp, double zTemp, string nameT)
                : base(xTemp, yTemp, zTemp, nameT)
            {
                // change these assignments
                x1 = x2 = x3 = xTemp;
                y1 = y2 = y3 = yTemp;
                z1 = z2 = z3 = zTemp;
            }
            // function to calculate surface area
            public double CalculatedSurfaceArea()
            {
                return 2 * ((x3 - x1)*(z2 - z1));
            }

            // function to calculate volume
            public double CalculatedVolume()
            {
                return Math.Pow((x2 - x1), 3);
            }        
    }
}
