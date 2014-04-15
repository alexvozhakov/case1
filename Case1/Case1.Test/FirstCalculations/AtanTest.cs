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
    public class AtanTest
    {
        [Test]
        public void AtangTest()
        {
            IOneCalculation calculater = FactoryClass2.CreateOperation("Atan");
            double result = calculater.Calculate(1);
            Assert.AreEqual(0.7853, result, 0.0001);
        }
    }
}
