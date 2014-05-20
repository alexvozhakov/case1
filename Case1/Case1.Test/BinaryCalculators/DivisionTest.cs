using Case1.BinaryCalculators;
using NUnit.Framework;

namespace Case1.Test.BinaryCalculators
{
    [TestFixture]
    public class DivisionTest
    {
        [Test]
        public void SubTest()
        {
            IBinaryCalculation calculater = BinaryFactory.CreateOperation("Sub");
            double result = calculater.Calculate(10, 2);
            Assert.AreEqual(5, result);
        }
    }
}
