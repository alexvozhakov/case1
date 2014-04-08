using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Case1.BinaryCalculators;
using NUnit.Framework;

namespace Case1.Test.BinaryCalculators
{
    [TestFixture]
    public class DedTest
    {
        [Test]
        public void DeducTest()
        {
            IBinaryCalculation calculater = FactoryClass.CreateOperation("Ded");
            double result = calculater.Calculate(4, 3);
            Assert.AreEqual(1, result);
        }
    }
}
