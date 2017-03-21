using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : ShapeBase, Interface2DShapes
    {
        private double x1, x2, y1, y2; 
        public Square()
        {
            x1 = x2 = y1 = 0;
        }

        public Square(double xTemp, double yTemp, double zTemp, string nameT)
            :base(xTemp, yTemp, zTemp, nameT)
        {  
            x1 = xTemp;
            x2 = xTemp;
            y1 = yTemp;
        }

        // overriding the base class functions
        public double CalculatedPerimeter()
        {
            return 2*((x2 - x1) + (x2 - y1));
        }

        public double CalculatedArea()
        {
            return (x2 - x1) * (x2 - y1);
        }
    }
}
