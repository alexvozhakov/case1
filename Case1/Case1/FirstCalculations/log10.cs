using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case1.FirstCalculations
{
    class log10:IOneCalculation
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Log10(firstArgument);
            return result.ToString();
        }
    }
}
