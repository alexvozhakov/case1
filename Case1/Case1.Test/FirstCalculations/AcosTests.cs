using System;
using Case1.UnaryCalculations;
using NUnit.Framework;

namespace Case1.Test.FirstCalculations
{
    [TestFixture]
    public class AcosTests
    {
        [Test]
        public void AcosinusTest()
        {
            IOneCalculation calculater = UnaryFactory.CreateOperation("Acos");
            double result = calculater.Calculate(1);
            Assert.AreEqual(0, result);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Logar10FailTest()
        {
            IOneCalculation calculater = UnaryFactory.CreateOperation("Acos");
            double result = calculater.Calculate(-2);
        }
    }
}
