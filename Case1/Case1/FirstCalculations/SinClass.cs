using System;

namespace Case1.FirstCalculations
{
    public class SinClass:IOneCalculation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Sin(firstArgument);
            return result;
        }
    }
}
