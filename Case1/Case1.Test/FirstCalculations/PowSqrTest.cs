using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Case1.FirstCalculations;
using NUnit.Framework;

namespace Case1.Test.FirstCalculations
{
    [TestFixture]
    public class PowSqrTest
    {
        [Test]
        public void PsTest()
        {
            IOneCalculation calculater = FactoryClass2.CreateOperation("Powsqr");
            double result = calculater.Calculate(4);
            Assert.AreEqual(16, result);
        }
    }
}
