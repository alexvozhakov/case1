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
    public class TanClass
    {
        [Test]
        public void TangensClass()
        {
            IOneCalculation calculater = FactoryClass2.CreateOperation("Tan");
            double result = calculater.Calculate(0);
            Assert.AreEqual(0, result);
        }
    }
}
