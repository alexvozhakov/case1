using System;
using Case1.UnaryCalculations;
using NUnit.Framework;

namespace Case1.Test.FirstCalculations
{
    [TestFixture]
    public class SqrtTests
    {
        [Test]
        public void KvKorTest()
        {
            IOneCalculation calculater = UnaryFactory.CreateOperation("Sqrt");
            double result = calculater.Calculate(16);
            Assert.AreEqual(4, result);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void KvKorFailTest()
        {
            IOneCalculation calculater = UnaryFactory.CreateOperation("Sqrt");
            double result = calculater.Calculate(-16);

        }
    }
}
