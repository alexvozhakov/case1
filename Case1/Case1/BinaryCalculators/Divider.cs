using System;

namespace Case1.BinaryCalculators
{
    public class Divider:IBinaryCalculation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new ArgumentException("Делитель не может быть равен 0");
            }
            double result = firstArgument / secondArgument;
            return result;
        }
    }
}
