using Case1.UnaryCalculations;
using NUnit.Framework;

namespace Case1.Test.FirstCalculations
{
    [TestFixture]
    public class PowSqrTests
    {
        [Test]
        public void PsTest()
        {
            IOneCalculation calculater = UnaryFactory.CreateOperation("Powsqr");
            double result = calculater.Calculate(4);
            Assert.AreEqual(16, result);
        }
    }
}
