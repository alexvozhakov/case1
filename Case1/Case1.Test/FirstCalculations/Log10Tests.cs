using System;
using Case1.UnaryCalculations;
using NUnit.Framework;

namespace Case1.Test.FirstCalculations
{
    [TestFixture]
    public class Log10Tests
    {
        [Test]
        public void Logar10Test()
        {
            IOneCalculation calculater = UnaryFactory.CreateOperation("log10");
            double result = calculater.Calculate(25);
            Assert.AreEqual(1.3979, result, 0.0001);
        }
       
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Logar10FailTest()
        {
            IOneCalculation calculater = UnaryFactory.CreateOperation("log10");
            double result = calculater.Calculate(-25);
        }
        
    }
}
