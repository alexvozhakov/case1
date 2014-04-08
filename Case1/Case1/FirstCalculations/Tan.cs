using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case1.FirstCalculations
{
    public class Tan : IOneCalculation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Tan(firstArgument);
            return result;
        }
    }
}
