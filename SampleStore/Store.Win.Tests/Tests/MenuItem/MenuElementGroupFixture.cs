using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Moq;
using NUnit.Framework;
using Store.Controls;
using Store.Domain;

namespace Store.Win.Tests.Tests.MenuItem
{
    [TestFixture]
    public class MenuElementGroupFixture
    {
        private static readonly string GroupCaption = Random.Sentence();
        private static readonly string GroupTooltip = Random.Sentence();
        private static readonly Glyph GroupGlyph = Random.Glyph();

        private static readonly string Item1Caption = Random.Sentence();
        private static readonly string Item1Tooltip = Random.Sentence();
        private static readonly Glyph Item1Glyph = Random.Glyph();

        private static readonly string Item2Caption = Random.Sentence();
        private static readonly string Item2Tooltip = Random.Sentence();
        private static readonly Glyph Item2Glyph = Random.Glyph();

        private MenuStrip _mainMenu;
        private MenuElementGroup _menuGroup;
        private MenuElement[] _options;
        private Mock<MenuElement> _menuItem1;
        private Mock<MenuElement> _menuItem2;

        [SetUp]
        public void Setup()
        {
            _menuItem1 = NewMenuElement(Item1Caption, Item1Tooltip, Item1Glyph);
            _menuItem2 = NewMenuElement(Item2Caption, Item2Tooltip, Item2Glyph);
            
            _options = new[] { _menuItem1.Object, _menuItem2.Object };
            _menuGroup = new MenuElementGroup
                             {
                                 Caption = GroupCaption,
                                 Glyph = GroupGlyph,
                                 Tooltip = GroupTooltip,
                                 Options = _options
                             };

            _mainMenu = new MenuStrip();
        }

        private static Mock<MenuElement> NewMenuElement(string caption, string tooltip, Glyph glyph)
        {
            return new Mock<MenuElement>(caption, tooltip, glyph);
        }

        [Test]
        public void AddTo_adds_one_item_to_menu()
        {
            _menuGroup.AddTo(_mainMenu);

            var toolStripItems = MainMenuItems();
            Assert.That(toolStripItems.Count(), Is.EqualTo(1));
        }

        [Test]
        public void AddTo_adds_an_element_matching_menuGroup()
        {
            _menuGroup.AddTo(_mainMenu);

            var toolStripItem = MainMenuItems().First();

            Assert.That(toolStripItem.Text, Is.EqualTo(_menuGroup.Caption));
            Assert.That(toolStripItem.ToolTipText, Is.EqualTo(_menuGroup.Tooltip));
            Assert.That(toolStripItem.Image, Is.EqualTo(_menuGroup.Glyph.Small));
        }
        
        private IEnumerable<ToolStripItem> MainMenuItems()
        {
            return _mainMenu.Items.Cast<ToolStripItem>();
        }

        [Test]
        public void AddTo_adds_matching_options()
        {
            _menuGroup.AddTo(_mainMenu);

            var subMenu = (ToolStripMenuItem)_mainMenu.Items[0];
            
            _menuItem1.Verify(m => m.AddTo(subMenu));
            _menuItem2.Verify(m => m.AddTo(subMenu));
        }

        [Test]
        public void Null_options_is_equivalent_to_empty()
        {
            Assert.DoesNotThrow(() =>
                new MenuElementGroup().AddTo(_mainMenu));
        }

        [Test]
        public void AddTo_sets_no_image_if_no_glyph()
        {
            new MenuElementGroup()
                .AddTo(_mainMenu);

            var toolStripItem = MainMenuItems().First();

            Assert.That(toolStripItem.Image, Is.Null);
        }
    }
}
