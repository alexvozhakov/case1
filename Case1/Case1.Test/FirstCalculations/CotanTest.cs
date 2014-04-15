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
    class CotanTest
    {
        [Test]
        public void CotTest()
        {
            IOneCalculation calculater = FactoryClass2.CreateOperation("Ctan");
            double result = calculater.Calculate(0.5);
            Assert.AreEqual(1.8304, result, 0.0001);
        }
    }
}
