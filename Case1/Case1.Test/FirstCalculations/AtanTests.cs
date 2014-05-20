using Case1.UnaryCalculations;
using NUnit.Framework;

namespace Case1.Test.FirstCalculations
{
    [TestFixture]
    public class AtanTests
    {
        [Test]
        public void AtangTest()
        {
            IOneCalculation calculater = UnaryFactory.CreateOperation("Atan");
            double result = calculater.Calculate(1);
            Assert.AreEqual(0.7853, result, 0.0001);
        }
    }
}
