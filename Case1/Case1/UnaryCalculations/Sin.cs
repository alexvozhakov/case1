using System;

namespace Case1.UnaryCalculations
{
    public class Sin:IOneCalculation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Sin(firstArgument);
            return result;
        }
    }
}
