using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
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

        [SetUp]
        public void Setup()
        {
            _options = new[] {new MenuElement(Item1Caption, Item1Tooltip, Item1Glyph), 
                new MenuElement(Item2Caption, Item2Tooltip, Item2Glyph)};
            _menuGroup = new MenuElementGroup
                             {
                                 Caption = GroupCaption,
                                 Glyph = GroupGlyph,
                                 Tooltip = GroupTooltip,
                                 Options = _options
                             };

            _mainMenu = new MenuStrip();
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

        [Test]
        public void AddTo_adds_all_options()
        {
            _menuGroup.AddTo(_mainMenu);

            var subMenu = (ToolStripMenuItem) _mainMenu.Items[0];

            Assert.That(subMenu.DropDownItems.Count, Is.EqualTo(2));
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

            var toolStripItem1 = subMenu.DropDownItems.Cast<ToolStripItem>().First();
            var toolStripItem2 = subMenu.DropDownItems.Cast<ToolStripItem>().Last();

            Assert.That(toolStripItem1.Text, Is.EqualTo(Item1Caption));
            Assert.That(toolStripItem1.ToolTipText, Is.EqualTo(Item1Tooltip));
            Assert.That(toolStripItem1.Image, Is.EqualTo(Item1Glyph.Small));

            Assert.That(toolStripItem2.Text, Is.EqualTo(Item2Caption));
            Assert.That(toolStripItem2.ToolTipText, Is.EqualTo(Item2Tooltip));
            Assert.That(toolStripItem2.Image, Is.EqualTo(Item2Glyph.Small));
        }
    }
}
