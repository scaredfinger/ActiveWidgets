using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using CG.Controls.NavigationBar;
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

        private static readonly string Option1Caption = Random.Sentence();
        private static readonly string Option1Tooltip = Random.Sentence();
        private static readonly Glyph Option1Glyph = Random.Glyph();

        private static readonly string Option2Caption = Random.Sentence();
        private static readonly string Option2Tooltip = Random.Sentence();
        private static readonly Glyph Option2Glyph = Random.Glyph();

        private MenuStrip _menuStrip;
        private MenuElementGroup _menuGroup;
        private ExNavigationBar _navBar;
        private MenuElement[] _options;
        private Mock<MenuElement> _menuItem1;
        private Mock<MenuElement> _menuItem2;

        [SetUp]
        public void Setup()
        {
            _menuItem1 = NewMenuElement(Option1Caption, Option1Tooltip, Option1Glyph);
            _menuItem2 = NewMenuElement(Option2Caption, Option2Tooltip, Option2Glyph);
            
            _options = new[] { _menuItem1.Object, _menuItem2.Object };
            _menuGroup = new MenuElementGroup
                             {
                                 Caption = GroupCaption,
                                 Glyph = GroupGlyph,
                                 Tooltip = GroupTooltip,
                                 Options = _options
                             };
            
            _navBar = new ExNavigationBar();

            _menuStrip = new MenuStrip();
        }

        private static Mock<MenuElement> NewMenuElement(string caption, string tooltip, Glyph glyph)
        {
            return new Mock<MenuElement>(caption, tooltip, glyph);
        }

        [Test]
        public void AddTo_adds_one_item_to_menu()
        {
            _menuGroup.AddTo(_menuStrip);

            var toolStripItems = MainMenuItems();
            Assert.That(toolStripItems.Count(), Is.EqualTo(1));
        }

        [Test]
        public void AddTo_adds_an_element_matching_menuGroup()
        {
            _menuGroup.AddTo(_menuStrip);

            var toolStripItem = MainMenuItems().First();

            Assert.That(toolStripItem.Text, Is.EqualTo(_menuGroup.Caption));
            Assert.That(toolStripItem.ToolTipText, Is.EqualTo(_menuGroup.Tooltip));
            Assert.That(toolStripItem.Image, Is.EqualTo(_menuGroup.Glyph.Small));
        }
        
        private IEnumerable<ToolStripItem> MainMenuItems()
        {
            return _menuStrip.Items.Cast<ToolStripItem>();
        }

        [Test]
        public void AddTo_adds_matching_options()
        {
            _menuGroup.AddTo(_menuStrip);

            var subMenu = (ToolStripMenuItem)_menuStrip.Items[0];
            
            _menuItem1.Verify(m => m.AddTo(subMenu));
            _menuItem2.Verify(m => m.AddTo(subMenu));
        }

        [Test]
        public void Null_options_is_equivalent_to_empty()
        {
            Assert.DoesNotThrow(() =>
                new MenuElementGroup().AddTo(_menuStrip));
        }

        [Test]
        public void AddTo_sets_no_image_if_no_glyph()
        {
            new MenuElementGroup()
                .AddTo(_menuStrip);

            var toolStripItem = MainMenuItems().First();

            Assert.That(toolStripItem.Image, Is.Null);
        }
        
        [Test]
        public void AddTo_adds_a_group_to_nav_bar()
        {
        	_menuGroup.AddTo(_navBar) ;
        	
        	Assert.That(_navBar.HasChildren);
        }
        
        [Test]
        public void AddTo_adds_a_matching_group()
        {
        	_menuGroup.AddTo(_navBar);
        	
        	var panel = _navBar.SelectedPanel;
        	
        	Assert.That(panel.Text, Is.EqualTo(GroupCaption));
        	Assert.That(panel.PanelImage, Is.EqualTo(GroupGlyph.Medium));
        }
        
        [Test]
        public void AddTo_throws_no_exceptions_if_no_glyph()
        {
        	Assert.DoesNotThrow(() =>
        		new MenuElementGroup().AddTo(_navBar));
        }
        
        [Test]
        public void AddTo_adds_all_options()
        {
        	_menuGroup.AddTo(_navBar);
        	
        	var navPanel = _navBar.SelectedPanel ;
        	var flowPanel = navPanel.Controls[0] as Panel;
        	
        	_menuItem1.Verify(m => m.AddTo(flowPanel));
        	_menuItem2.Verify(m => m.AddTo(flowPanel));
        }
    }
}
