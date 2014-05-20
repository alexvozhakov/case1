using System;

namespace Case1.UnaryCalculations
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
