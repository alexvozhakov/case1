using System;

namespace Case1.UnaryCalculations
{
    public static class UnaryFactory
    {
        public static IOneCalculation CreateOperation(string name)
        {
            switch (name)
            {
                case "Sin":
                    return new Sin();
                case "Cos":
                    return new Cos();
                case "Tan":
                    return new Tan();
                case "Ctan":
                    return new Ctan();
                case "Sqrt":
                    return new Sqrt();
                case "Powsqr":
                    return new Powsqr();
                case "log10":
                    return new Log10();
                case "Acos":
                    return new Acos();
                case "Asin":
                    return new Asin();
                case "Atan":
                    return new Atan();
                case "ln":
                    return new Ln();
                default:
                    throw new ArgumentException("Unknown argument", "name");
            }
        }
    }
}