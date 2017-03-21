// Name: Rephael Edwards
// File: ShapeBase.cs
// Description: The class which processes the exception thrown
//              for negative numbers
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class NegativeNumberException : ApplicationException
    {
        // default constructor
        public NegativeNumberException() : base (" Cannot have a negative radius," 
            +" height, length or width. \n Ensure that your second coordinates are larger" + 
            " than the first")
        {

        }

        //parameterized constructor
       public NegativeNumberException(string message) : base (message)
        {

        }

        
        
    }

    
}
