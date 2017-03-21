// Name: Rephael Edwards
// File: ShapeBase.cs
// Description: The base class for the shapes.
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public abstract class ShapeBase
    {
        // properties
        private double x;
        private double y;
        private double z;
        private string name;

        // constructor
        public ShapeBase()
        {
            x = y = z = 0;
            // what to do with name?
        }

        // parameterized constructor  
        public ShapeBase(double xTemp, double yTemp, double zTemp, string nameT)
        {
            x = xTemp;
            y = yTemp;
            z = zTemp;
            name = nameT;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return "";
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

    }
}
