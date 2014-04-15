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
    public class SubstractTest
    {
        [Test]
        public void SubTest()
        {
            IBinaryCalculation calculater = FactoryClass.CreateOperation("Sub");
            double result = calculater.Calculate(10, 2);
            Assert.AreEqual(5, result);
        }
    }
}
