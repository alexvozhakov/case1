using System;

namespace Case1.MassSort
{
    public static class FactorySort
    {
        public static ISort CreateOperation(string name)
        {
            switch (name)
            {
                case "Bubble":
                    return new Bubble();
                case "Dwarf":
                    return new Dwarf();
                default:
                    throw new ArgumentException("Unknown argument", "name");
            }
        }
    }
}
