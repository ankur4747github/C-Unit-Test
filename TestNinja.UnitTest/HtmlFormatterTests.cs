using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    internal class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ReturnStringWithStong()
        {
            var htmlFormatter = new HtmlFormatter();
            var result = htmlFormatter.FormatAsBold("abc");

            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));
        }
    }
}