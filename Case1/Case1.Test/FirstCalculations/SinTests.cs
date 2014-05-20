using Case1.UnaryCalculations;
using NUnit.Framework;

namespace Case1.Test.FirstCalculations
{
    [TestFixture]
    public class SinTests
    {
        [Test]
        public void SinusTest()
        {
            IOneCalculation calculater = UnaryFactory.CreateOperation("Sin");
            double result = calculater.Calculate(0);
            Assert.AreEqual(0, result);
        }
    }
}
