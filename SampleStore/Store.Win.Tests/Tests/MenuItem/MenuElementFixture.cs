using System.Windows.Forms;
using NUnit.Framework;
using Store.Controls;

namespace Store.Win.Tests.Tests.MenuItem
{
    [TestFixture]
    public class MenuElementFixture
    {
        private static readonly string ItemCaption = Random.Sentence();
        private static readonly string ItemTooltip = Random.Sentence();
        private static readonly Glyph ItemGlyph = Random.Glyph();

        private MenuElement _item;
        private ToolStripMenuItem _menu;

        [SetUp]
        public void Setup()
        {
            _menu = new ToolStripMenuItem();

            _item = new MenuElement(ItemCaption, ItemTooltip, ItemGlyph);
        }

        [Test]
        public void AddTo_adds_an_element_to_menu()
        {
            _item.AddTo(_menu);

            Assert.That(_menu.DropDownItems.Count, Is.EqualTo(1));
        }

        [Test]
        public void AddTo_adds_matching_element_to_menu()
        {
            _item.AddTo(_menu);

            var item = GetItem();
            Assert.That(item.Text, Is.EqualTo(ItemCaption));
            Assert.That(item.ToolTipText, Is.EqualTo(ItemTooltip));
            Assert.That(item.Image, Is.EqualTo(ItemGlyph.Small));
        }

        private ToolStripItem GetItem()
        {
            return _menu.DropDownItems[0];
        }

        [Test]
        public void AddTo_sets_image_to_null_if_glyph_is_null()
        {
            new MenuElement(null, null, null).AddTo(_menu);

            var item = GetItem();

            Assert.That(item.Image, Is.Null);
        }
    }
}