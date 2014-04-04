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
                default:
                    throw new ArgumentException("Unknown argument", "name");
            }
        }
    }
}