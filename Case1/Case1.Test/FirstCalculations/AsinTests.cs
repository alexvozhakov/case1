using System;
using Case1.UnaryCalculations;
using NUnit.Framework;

namespace Case1.Test.FirstCalculations
{
    [TestFixture]
    public class AsinTests
    {
        [Test]
        public void AsinusTest()
        {
            IOneCalculation calculater = UnaryFactory.CreateOperation("Asin");
            double result = calculater.Calculate(1);
            Assert.AreEqual(1.5708, result, 0.0001);
        }


        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Logar10FailTest()
        {
            IOneCalculation calculater = UnaryFactory.CreateOperation("Asin");
            double result = calculater.Calculate(-2);
        }
    }
}
