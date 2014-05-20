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
            IBinaryCalculation calculater = BinaryFactory.CreateOperation("Mult");
            double result = calculater.Calculate(4, 3);
            Assert.AreEqual(12, result);
        }
    }
}
