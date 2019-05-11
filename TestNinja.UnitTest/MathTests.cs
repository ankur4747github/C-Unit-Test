using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void Setup()
        {
            _math = new Math();
        }

        [Test]
        [Ignore("Because I want it..")]
        public void Add_WhenCalled_ReturnTheSumArguments()
        {
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(11, 12, 12)]
        [TestCase(12, 12, 12)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int c)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(c));
        }
    }
}