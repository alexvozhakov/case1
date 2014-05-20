using System;

namespace Case1.BinaryCalculators
{
    class Pow : IBinaryCalculation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            double result = Math.Pow(firstArgument, secondArgument);
            return result;
        }
    }
}
