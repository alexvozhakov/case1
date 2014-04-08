namespace Case1.BinaryCalculators
{
    public class Deduction:IBinaryCalculation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            double result = firstArgument - secondArgument;
            return result;
        }
    }
}
