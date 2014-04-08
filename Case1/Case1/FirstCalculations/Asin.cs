using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Case1.FirstCalculations
{
    public class Asin: IOneCalculation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Asin(firstArgument);
            return result;
        }
    }
}
