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
    public class SqrtTest
    {
        [Test]
        public void KvKorTest()
        {
            IOneCalculation calculater = FactoryClass2.CreateOperation("Sqrt");
            double result = calculater.Calculate(16);
            Assert.AreEqual(4, result);
        }
    }
}
