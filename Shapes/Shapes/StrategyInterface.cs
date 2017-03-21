using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesLibrary;

namespace WorldofShapes
{
    interface StrategyInterface
    {
        void ShowOptions();
        void GatherInput();
        void ValidateInput();
        void ProcessInput();
    }
}
