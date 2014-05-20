using System;

namespace Case1.UnaryCalculations
{
    public class Cos : IOneCalculation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Cos(firstArgument);
            return result;
        }
    }
}
