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
    public class MultTest
    {
        [Test]
        public void MiltiTest()
        {
            IBinaryCalculation calculater = FactoryClass.CreateOperation("Mult");
            double result = calculater.Calculate(4, 3);
            Assert.AreEqual(12, result);
        }
    }
}
