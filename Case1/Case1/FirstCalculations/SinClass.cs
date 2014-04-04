using System;

namespace Case1.FirstCalculations
{
    public class SinClass:IOneCalculation
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Sin(firstArgument);
            return result.ToString();
        }
    }
}
