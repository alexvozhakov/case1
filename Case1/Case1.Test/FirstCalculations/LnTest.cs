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
    public class LnTest
    {
        [Test]
        public void LnatTest()
        {
            IOneCalculation calculater = FactoryClass2.CreateOperation("ln");
            double result = calculater.Calculate(10);
            Assert.AreEqual(2.3025, result, 0.0001);
        }
    }
}
