using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Case1.BinaryCalculators;
using NUnit.Framework;

namespace Case1.Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void AddTest()
        {
            IBinaryCalculation calculater = FactoryClass.CreateOperation("Add");
            double result = calculater.Calculate(0.1, 3.4);
            Assert.AreEqual(3.5, result);
        }
    }
}
