using Case1.UnaryCalculations;
using NUnit.Framework;

namespace Case1.Test.FirstCalculations
{
    [TestFixture]
    public class CosTests
    {
        [Test]
        public void CosinusTest()
        {
            IOneCalculation calculater = UnaryFactory.CreateOperation("Cos");
            double result = calculater.Calculate(0);
            Assert.AreEqual(1, result);
        }
    }
}
