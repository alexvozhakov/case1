using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Case1.FirstCalculations
{
    class Atan: IOneCalculation
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Atan(firstArgument);
            return result.ToString();
        }
    }
}
