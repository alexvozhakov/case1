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
    public class AsinTest
    {
        [Test]
        public void AsinusTest()
        {
            IOneCalculation calculater = FactoryClass2.CreateOperation("Asin");
            double result = calculater.Calculate(1);
            Assert.AreEqual(1.5708, result, 0.0001);
        }
    }
}
