using Case1.BinaryCalculators;
using NUnit.Framework;

namespace Case1.Test.BinaryCalculators
{
    [TestFixture]
    public class PowTest
    {
        [Test]
        public void PohTest()
        {
            IBinaryCalculation calculater = BinaryFactory.CreateOperation("Pow");
            double result = calculater.Calculate(4, 2);
            Assert.AreEqual(16, result);
        }
    }
}
