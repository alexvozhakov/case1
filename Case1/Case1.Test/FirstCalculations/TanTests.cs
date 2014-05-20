using Case1.UnaryCalculations;
using NUnit.Framework;

namespace Case1.Test.FirstCalculations
{
    [TestFixture]
    public class TanTests
    {
        [Test]
        public void TangensClass()
        {
            IOneCalculation calculater = UnaryFactory.CreateOperation("Tan");
            double result = calculater.Calculate(0);
            Assert.AreEqual(0, result);
        }
    }
}
