using Case1.MassSort;
using NUnit.Framework;

namespace Case1.Test.MassSort
{
    [TestFixture]
    class BubbleTest
    {
        [Test]
        public void BubTest()
        {
            ISort calculater = FactorySort.CreateOperation("Bubble");
            int[] result = calculater.SortMass(new []{5, 6, 3, 2, 9, 10, 12});
            var expected = new[] {2, 3, 5, 6, 9, 10, 12}; 
            Assert.AreEqual(expected, result);
        }
    }
}
