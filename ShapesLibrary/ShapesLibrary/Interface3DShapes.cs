// Name: Rephael Edwards
// File: ShapeBase.cs
// Description: The interface for 3D shapes.
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    interface Interface3DShapes
    {
        // function to calculate surface area
        double CalculatedSurfaceArea();

        // function to calculate volume
        double CalculatedVolume();

    }
}
