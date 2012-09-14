using ActiveWidgets.Utils;
using NUnit.Framework;

namespace ActiveWidgets.Tests.Units.Utils
{
    [TestFixture]
    public class RenderTextExtensionFixture
    {
        [Test]
        public void Renders()
        {
            var rendered = "{0},{1}".Render('a', 'b');

            Assert.That(rendered, Is.EqualTo("a,b"));
        }
    }
}