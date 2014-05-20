using System;
using Case1.UnaryCalculations;
using NUnit.Framework;

namespace Case1.Test.FirstCalculations
{
    [TestFixture]
    public class LnTests
    {
        [Test]
        public void LnTest()
        {
            IOneCalculation calculater = UnaryFactory.CreateOperation("ln");
            double result = calculater.Calculate(10);
            Assert.AreEqual(2.3025, result, 0.0001);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void LnFailTest()
        {
            IOneCalculation calculater = UnaryFactory.CreateOperation("ln");
            double result = calculater.Calculate(-25);
        }
    }
}
