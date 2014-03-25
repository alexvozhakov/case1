using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Case1.BinaryCalculators
{
    public static class FabricClass
    {
        public static IBinaryCalculation CreateOperation(string name)
        {
            switch (name)
            {
                case "Adder":
                    return new Adder();
                case "Deduction":
                    return new Deduction();
                case "Mult":
                    return new Multiplication();
                case "Sub":
                    return new Substraction();
                default:
                    throw new ArgumentException("Unknown argument", "name");
            }
        }
    }
}
