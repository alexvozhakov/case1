using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case1.FirstCalculations
{
    class Powsqr:IOneCalculation
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Pow(firstArgument, 2);
            return result.ToString();
        }
    }
}
