using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case1.FirstCalculations
{
    public static class FactoryClass2
    {
        public static IOneCalculation CreateOperation(string name)
        {
            switch (name)
            {
                case "Sin":
                    return new SinClass();
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
                    return new log10();
                case "Acos":
                    return new Acos();
                case "Asin":
                    return new Asin();
                case "Atan":
                    return new Atan();
                case "ln":
                    return new ln();
                default:
                    throw new ArgumentException("Unknown argument", "name");
            }
        }
    }
}