using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Case1.MassSort;
using NUnit.Framework;

namespace Case1.Test.MassSort
{
    [TestFixture]
    public class DwarfTest
    {
        [Test]
        public void GnomTest()
        {
            ISort calculater = FactorySort.CreateOperation("Dwarf");
            int[] result = calculater.SortMass(new[] { 5, 6, 3, 2, 9, 10, 12 });
            int[] expected = new[] { 2, 3, 5, 6, 9, 10, 12 };
            Assert.AreEqual(expected, result);
        }
    }
}
