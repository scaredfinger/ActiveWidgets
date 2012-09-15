using System.Windows.Forms;
using CG.Controls.Grid.Buttons;
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
        private Panel _panel;

        [SetUp]
        public void Setup()
        {
            _menu = new ToolStripMenuItem();
            _panel = new Panel();

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
        
        [Test]
        public void AddTo_sets_a_hyperlink_in_panel()
        {
        	_item.AddTo(_panel);
        	
        	Assert.That(_panel.Controls[0], Is.InstanceOf<ExHyperlink>());
        }
        
        [Test]
        public void AddTo_adds_a_matching_hyperlink()
        {
        	_item.AddTo(_panel);
        	
        	var hyperlink = _panel.Controls[0] as ExHyperlink;
        	
        	Assert.That(hyperlink.Text, Is.EqualTo(ItemCaption));
        	Assert.That(hyperlink.Image, Is.EqualTo(ItemGlyph.Small));
        }
        
        [Test]
        public void AddTo_sets_null_image_if_glyph_is_null()
        {
        	new MenuElement().AddTo(_panel);
        	
        	var hyperlink = _panel.Controls[0] as ExHyperlink;
        	
        	Assert.That(hyperlink.Image, Is.Null);
        }
    }
}