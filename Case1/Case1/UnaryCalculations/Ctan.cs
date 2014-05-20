using System;

namespace Case1.UnaryCalculations
{
    class Ctan : IOneCalculation
    {
        public double Calculate(double firstArgument)
        {
            double result = 1/Math.Tan(firstArgument);
            return result;
        }
    }
}
