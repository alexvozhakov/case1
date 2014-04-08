using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case1.FirstCalculations
{
    public class Sqrt:IOneCalculation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Sqrt(firstArgument);
            return result;
        }
    }
}
