using System;

namespace Case1.UnaryCalculations
{
    class Powsqr : IOneCalculation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Pow(firstArgument, 2);
            return result;
        }
    }
}
