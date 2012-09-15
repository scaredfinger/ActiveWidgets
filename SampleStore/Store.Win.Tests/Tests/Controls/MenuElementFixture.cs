using System.Windows.Forms;
using CG.Controls.Grid.Buttons;
using NUnit.Framework;
using Store.Controls;

namespace Store.Win.Tests.Tests.MenuItem
{
    [TestFixture]
    public class MenuElementFixture
    {
        private static readonly string ElementCaption = Random.Sentence();
        private static readonly string ElementTooltip = Random.Sentence();
        private static readonly Glyph ElementGlyph = Random.Glyph();

        private MenuElement _element;
        
        private ToolStripMenuItem _menu;
        private Panel _panel;
        private ToolStrip _toolbar ;

        [SetUp]
        public void Setup()
        {
            _menu = new ToolStripMenuItem();
            _panel = new Panel();
            _toolbar = new ToolStrip();

            _element = new MenuElement(ElementCaption, ElementTooltip, ElementGlyph);
        }

        [Test]
        public void AddTo_adds_an_element_to_menu()
        {
            _element.AddTo(_menu);

            Assert.That(_menu.DropDownItems.Count, Is.EqualTo(1));
        }

        [Test]
        public void AddTo_adds_matching_element_to_menu()
        {
            _element.AddTo(_menu);

            var item = GetItem();
            Assert.That(item.Text, Is.EqualTo(ElementCaption));
            Assert.That(item.ToolTipText, Is.EqualTo(ElementTooltip));
            Assert.That(item.Image, Is.EqualTo(ElementGlyph.Small));
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
        	_element.AddTo(_panel);
        	
        	Assert.That(_panel.Controls[0], Is.InstanceOf<ExHyperlink>());
        }
        
        [Test]
        public void AddTo_adds_a_matching_hyperlink()
        {
        	_element.AddTo(_panel);
        	
        	var hyperlink = _panel.Controls[0] as ExHyperlink;
        	
        	Assert.That(hyperlink.Text, Is.EqualTo(ElementCaption));
        	Assert.That(hyperlink.Image, Is.EqualTo(ElementGlyph.Small));
        }
        
        [Test]
        public void AddTo_sets_null_image_if_glyph_is_null()
        {
        	new MenuElement().AddTo(_panel);
        	
        	var hyperlink = _panel.Controls[0] as ExHyperlink;
        	
        	Assert.That(hyperlink.Image, Is.Null);
        }
        
        [Test]
        public void AddTo_adds_an_item_to_the_tool_strip()
        {
        	_element.AddTo(_toolbar);
        	
        	Assert.That(_toolbar.Items.Count, Is.EqualTo(1));
        }
        
        [Test]
        public void AddTo_adds_a_matching_item()
        {
        	_element.AddTo(_toolbar);
        	
        	var item = _toolbar.Items[0] ;
        	
        	Assert.That(item.Text, Is.EqualTo(ElementCaption));
        	Assert.That(item.ToolTipText, Is.EqualTo(ElementTooltip));
        	Assert.That(item.Image, Is.EqualTo(ElementGlyph.Small));
        }
        
        [Test]
        public void AddTo_sets_null_image_glyph_is_null()
        {
        	new MenuElement().AddTo(_toolbar);
        	
        	var item = _toolbar.Items[0] ;
        	
        	Assert.That(item.Image, Is.Null);        	
        }
    }
}