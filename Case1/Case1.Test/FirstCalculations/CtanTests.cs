using Case1.UnaryCalculations;
using NUnit.Framework;

namespace Case1.Test.FirstCalculations
{
    [TestFixture]
    class CtanTests
    {
        [Test]
        public void CotTest()
        {
            IOneCalculation calculater = UnaryFactory.CreateOperation("Ctan");
            double result = calculater.Calculate(0.5);
            Assert.AreEqual(1.8304, result, 0.0001);
        }
    }
}
