using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case1.FirstCalculations
{
    class Ctan : IOneCalculation
    {
        public string Calculate(double firstArgument)
        {
            double result = 1/Math.Tan(firstArgument);
            return result.ToString();
        }
    }
}
