using System;

namespace Case1.BinaryCalculators
{
    public static class BinaryFactory
    {
        public static IBinaryCalculation CreateOperation(string name)
        {
            switch (name)
            {
                case "Add":
                    return new Adder();
                case "Ded":
                    return new Substruction();
                case "Mult":
                    return new Multiplication();
                case "Sub":
                    return new Divider();
                case "Pow":
                    return new Pow();
                default:
                    throw new ArgumentException("Unknown argument", "name");
            }
        }
    }
}
