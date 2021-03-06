﻿using System;

namespace Case1.UnaryCalculations
{
    public class Ln : IOneCalculation
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0)
            {
                throw new ArgumentException("Аргумент логарифма не может быть меньше 0.");
            }
            if (firstArgument == 1)
            {
                throw new ArgumentException("Аргумент логарифма не может быть равен 1.");
            }
            double result = Math.Log(firstArgument);
            return result;
        }
    }
}
