using System;

namespace Case1.UnaryCalculations
{
    class Acos : IOneCalculation
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument < -1 || firstArgument > 1)
            {
                throw new ArgumentException("Не существуюещее значение");
            }
            double result = Math.Acos(firstArgument);
            return result;
        }
    }
}
