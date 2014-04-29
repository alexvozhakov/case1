using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case1.FirstCalculations
{
    public class ln: IOneCalculation
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0 || firstArgument == 1)
            {
                throw new ArgumentException("Неверное значение основания логарифма.");
            }
            double result = Math.Log(firstArgument);
            return result;
        }
    }
}
