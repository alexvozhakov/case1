namespace Case1.BinaryCalculators
{
    public class Adder:IBinaryCalculation
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            double result = firstArgument + secondArgument;
            return result.ToString();
        }
    }
}
