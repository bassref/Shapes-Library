using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle: ShapeBase, Interface2DShapes
    {
        private double radius;

        public Circle()
        {
            radius = 0;
        }

        public Circle(double tempRadius, double xTemp, double yTemp, double zTemp, string nameT)
            :base(xTemp, yTemp, zTemp, nameT)
        {
            radius = tempRadius;
        }

        
        // overriding the base class function
        public double CalculatedPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public double CalculatedArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
