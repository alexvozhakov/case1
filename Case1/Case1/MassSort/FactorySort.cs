using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                default:
                    throw new ArgumentException("Unknown argument", "name");
            }
        }
    }
}
