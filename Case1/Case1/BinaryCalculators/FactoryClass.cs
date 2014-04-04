using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Case1.BinaryCalculators
{
    public static class FactoryClass
    {
        public static IBinaryCalculation CreateOperation(string name)
        {
            switch (name)
            {
                case "Add":
                    return new Adder();
                case "Ded":
                    return new Deduction();
                case "Mult":
                    return new Multiplication();
                case "Sub":
                    return new Substraction();
                case "Pow":
                    return new Pow();
                default:
                    throw new ArgumentException("Unknown argument", "name");
            }
        }
    }
}
