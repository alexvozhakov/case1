using Case1.BinaryCalculators;
using NUnit.Framework;

namespace Case1.Test.BinaryCalculators
{
    [TestFixture]
    public class AdderTest
    {
        [Test]
        public void AddTest()
        {
            IBinaryCalculation calculater = FactoryClass.CreateOperation("Add");
            double result = calculater.Calculate(0.1, 3.4);
            Assert.AreEqual(3.5, result);
        }
    }
}
