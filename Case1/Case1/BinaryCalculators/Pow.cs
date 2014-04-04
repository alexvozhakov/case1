using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case1.BinaryCalculators
{
    class Pow:IBinaryCalculation
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            double result = Math.Pow(firstArgument , secondArgument);
            return result.ToString();
        }
    }
}
