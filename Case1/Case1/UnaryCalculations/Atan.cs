using System;

namespace Case1.UnaryCalculations
{
    class Atan : IOneCalculation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Atan(firstArgument);
            return result;
        }
    }
}
