using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : ShapeBase, Interface2DShapes
    {
        double x1, x2, y1, y2;
        public Rectangle()
        {
            x1 = x2 = y1 = y2 = 0;
        }

        public Rectangle(double xTemp, double yTemp, double zTemp, string nameT)
            :base(xTemp, yTemp, zTemp, nameT)
        {  
            x1 = xTemp;
            x2 = xTemp;
            y1 = yTemp;
            y2 = yTemp;
        }

        // overriding the base class functions
        public double CalculatedPerimeter()
        {
            return 2*((x2 - x1) + (y2 - y1));
        }

        public double CalculatedArea()
        {
            return (x2 - x1) * (y2 - y1);
        }
    }
}
