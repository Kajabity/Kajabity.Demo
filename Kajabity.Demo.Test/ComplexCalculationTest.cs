using NUnit.Framework;

namespace Kajabity.Demo.Test
{
    public class ComplexCalculationTest
    {
        [Test]
        public void Test1()
        {
            var cut = new ComplexCalculation();
            Assert.AreEqual(18, cut.TimesTwo(9));
        }
    }
}