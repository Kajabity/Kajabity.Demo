using NUnit.Framework;

namespace Kajabity.Demo.Test
{
    public class ComplexCalculationTest
    {
        [Test]
        public void Test1()
        {
            var cut = new ComplexCalculation();
            Assert.That(cut.TimesTwo(9), Is.EqualTo(18), "TimesTwo gave wrong result.");
        }
    }
}
