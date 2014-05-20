using System;

namespace Case1.UnaryCalculations
{
    public class Sqrt : IOneCalculation
    {
        public double Calculate(double firstArgument)
        {

            if (firstArgument < 0)
            {
                throw new ArgumentException("Квадратного корня из отрицательного чилса не существует.");
            }
            double result = Math.Sqrt(firstArgument);
            return result;
        }
    }
}
