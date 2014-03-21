using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case1.BinaryCalculators
{
    public static class BinaryOperatorFactory
    {
        public static IBinaryCalculation CreateOperation(string name)
        {
            switch (name)
            {
                case "Addition":
                    return new Adder();
                case "Deduction":
                    return new Deduction();
                case "Substraction":
                    return new Substraction();
                case "Multiplication":
                    return new Multiplication();
            }
        }
    }
}
