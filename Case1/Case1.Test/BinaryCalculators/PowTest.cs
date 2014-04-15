using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Case1.BinaryCalculators;
using NUnit.Framework;

namespace Case1.Test.BinaryCalculators
{
    [TestFixture]
    public class PowTest
    {
        [Test]
        public void PohTest()
        {
            IBinaryCalculation calculater = FactoryClass.CreateOperation("Pow");
            double result = calculater.Calculate(4, 2);
            Assert.AreEqual(16, result);
        }
    }
}
