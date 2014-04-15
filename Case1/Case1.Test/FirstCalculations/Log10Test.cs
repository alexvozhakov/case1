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
    public class Log10Test
    {
        [Test]
        public void Logar10Test()
        {
            IOneCalculation calculater = FactoryClass2.CreateOperation("log10");
            double result = calculater.Calculate(25);
            Assert.AreEqual(1.3979, result, 0.0001);
        }
    }
}
