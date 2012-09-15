using System;
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

			var item = GetMenuItem();
			
			Assert.That(item.Text, Is.EqualTo(ElementCaption));
			Assert.That(item.ToolTipText, Is.EqualTo(ElementTooltip));
			Assert.That(item.Image, Is.EqualTo(ElementGlyph.Small));
		}

		private ToolStripItem GetMenuItem()
		{
			return _menu.DropDownItems[0];
		}

		[Test]
		public void AddTo_sets_image_to_null_if_glyph_is_null()
		{
			new MenuElement(null, null, null).AddTo(_menu);

			var item = GetMenuItem();

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
			
			var hyperlink = GetHyperLink();
			
			Assert.That(hyperlink.Text, Is.EqualTo(ElementCaption));
			Assert.That(hyperlink.Image, Is.EqualTo(ElementGlyph.Small));
		}
		
		public ExHyperlink GetHyperLink()
		{
			return _panel.Controls[0] as ExHyperlink ;
		}
		
		[Test]
		public void AddTo_sets_null_image_if_glyph_is_null()
		{
			new MenuElement().AddTo(_panel);
			
			var hyperlink = GetHyperLink();
			
			Assert.That(hyperlink.Image, Is.Null);
		}
		
		[Test]
		public void AddTo_adds_an_item_to_toolbar()
		{
			_element.AddTo(_toolbar);
			
			Assert.That(_toolbar.Items.Count, Is.EqualTo(1));
		}
		
		[Test]
		public void AddTo_adds_a_image_only_item_to_toolbar()
		{
			_element.AddTo(_toolbar);
			
			var item = GetToolbarItem();
			
			Assert.That(item.DisplayStyle, Is.EqualTo(ToolStripItemDisplayStyle.Image));
		}
		
		[Test]
		public void AddTo_adds_a_matching_item_to_toolbar()
		{
			_element.AddTo(_toolbar);
			
			var item = GetToolbarItem();
			
			Assert.That(item.Text, Is.EqualTo(ElementCaption));
			Assert.That(item.ToolTipText, Is.EqualTo(ElementTooltip));
			Assert.That(item.Image, Is.EqualTo(ElementGlyph.Medium));
		}

		private ToolStripItem GetToolbarItem()
		{
			return _toolbar.Items[0];
		}
		
		[Test]
		public void AddTo_sets_null_image_glyph_is_null()
		{
			new MenuElement().AddTo(_toolbar);
			
			var item = GetToolbarItem();
			
			Assert.That(item.Image, Is.Null);
		}
		
		[Test]
		public void On_menu_item_clicked_trigges_action()
		{
			var actionHasBeenTriggered = false ;
			_element.Action += (s, e) => 
				actionHasBeenTriggered = true ;
			_element.AddTo(_menu) ;
			var item = GetMenuItem();
			
			item.PerformClick();
			
			Assert.That(actionHasBeenTriggered) ;
		}
		
		[Test]
		public void On_navbar_link_clicked_triggers_action()
		{
			var actionHasBeenTriggered = false ;
			_element.Action += (s, e) => 
				actionHasBeenTriggered = true ;
			_element.AddTo(_panel) ;
			var item = GetHyperLink();
			
			item.PerformClick();
			
			Assert.That(actionHasBeenTriggered);
		}
		
		[Test]
		public void On_toolbar_item_clicked_triggers_action()
		{
			var actionHasBeenTriggered = false ;
			_element.Action += (s, e) => 
				actionHasBeenTriggered = true ;
			_element.AddTo(_toolbar) ;
			var item = GetToolbarItem();
			
			item.PerformClick();
			
			Assert.That(actionHasBeenTriggered);
		}
		
		[Test]
		public void Disable_disables_menu_item()
		{
			_element.AddTo(_menu) ;
			var menuItem = GetMenuItem();
		
			_element.Disable();
			
			Assert.That(menuItem.Enabled, Is.False);
		}
		
		[Test]
		public void Disable_disables_toolbar_item()
		{
			_element.AddTo(_toolbar);
			var toolbarItem = GetToolbarItem();
		
			_element.Disable();
			
			Assert.That(toolbarItem.Enabled, Is.False);
		}
		
		[Test]
		public void Disable_disables_hyerlink()
		{
			_element.AddTo(_panel) ;			
			var hyperLink = GetHyperLink();
			
			_element.Disable();
			
			Assert.That(hyperLink.Enabled, Is.False);
		}
		
		[Test]
		public void Enable_enables_a_disabled_menu_item()
		{
			_element.AddTo(_menu) ;
			var menuItem = GetMenuItem();		
			_element.Disable();
			
			_element.Enable();
			
			Assert.That(menuItem.Enabled, Is.True);
		}
		
		[Test]
		public void Enable_enables_a_disabled_toolbar_item()
		{
			_element.AddTo(_toolbar);
			var toolbarItem = GetToolbarItem();
			_element.Disable();
			
			_element.Enable();
			
			Assert.That(toolbarItem.Enabled, Is.True);
		}
		
		[Test]
		public void Enable_enables_a_disabled_hyperlink_item()
		{
			_element.AddTo(_panel) ;			
			var hyperLink = GetHyperLink();
			_element.Disable();
			
			_element.Enable();
			
			Assert.That(hyperLink.Enabled, Is.True);
		}
		
		[Test]
		public void RemoveFrom_toolbar_removes_the_item()
		{
			_element.AddTo(_toolbar);
			
			_element.RemoveFrom(_toolbar) ;
			
			Assert.That(_toolbar.Items.Count, Is.EqualTo(0));
		}
		
		[Test]
		public void RemoveFrom_toolbar_throws_if_not_added()
		{
			Assert.Throws<ArgumentException>(() =>
				_element.RemoveFrom(_toolbar));
		}
		
		[Test]
		public void RemovesFrom_toolbar_removes_the_handler()
		{
			_element.AddTo(_toolbar);
			var item = GetToolbarItem();
			var actionHasNotBeenTriggered = true ;
			_element.Action += (s, e) =>
				actionHasNotBeenTriggered = false;
			
			_element.RemoveFrom(_toolbar);
			
			item.PerformClick();
			
			Assert.That(actionHasNotBeenTriggered);
		}
		
		[Test]
		public void RemoveFrom_menu_removes_the_item()
		{
			_element.AddTo(_menu);
			
			_element.RemoveFrom(_menu) ;
			
			Assert.That(_menu.DropDownItems.Count, Is.EqualTo(0));
		}
		
		[Test]
		public void RemoveFrom_menu_throws_if_not_added()
		{
			Assert.Throws<ArgumentException>(() =>
				_element.RemoveFrom(_menu));
		}
		
		[Test]
		public void RemovesFrom_menu_removes_the_handler()
		{
			_element.AddTo(_menu);
			var item = GetMenuItem();
			var actionHasNotBeenTriggered = true ;
			_element.Action += (s, e) =>
				actionHasNotBeenTriggered = false;
			
			_element.RemoveFrom(_menu);
			
			item.PerformClick();
			
			Assert.That(actionHasNotBeenTriggered);
		}
		
		[Test]
		public void RemoveFrom_panel_removes_the_item()
		{
			_element.AddTo(_panel);
			
			_element.RemoveFrom(_panel) ;
			
			Assert.That(_panel.Controls.Count, Is.EqualTo(0));
		}
		
		[Test]
		public void RemoveFrom_panel_throws_if_not_added()
		{
			Assert.Throws<ArgumentException>(() =>
				_element.RemoveFrom(_panel));
		}
		
		[Test]
		public void RemovesFrom_panel_removes_the_handler()
		{
			_element.AddTo(_panel);
			var item = GetHyperLink();
			var actionHasNotBeenTriggered = true ;
			_element.Action += (s, e) =>
				actionHasNotBeenTriggered = false;
			
			_element.RemoveFrom(_panel);
			
			item.PerformClick();
			
			Assert.That(actionHasNotBeenTriggered);
		}
		
		[Test]
		public void Dispose_removes_toolbar_handler()
		{
			_element.AddTo(_toolbar);
			var item = GetToolbarItem();
			var actionHasNotBeenTriggered = true ;
			_element.Action += (s, e) =>
				actionHasNotBeenTriggered = false;
			
			_element.Dispose();
			
			item.PerformClick();
			
			Assert.That(actionHasNotBeenTriggered);
		}
		
		[Test]
		public void Dispose_removes_menu_handler()
		{
			_element.AddTo(_menu);
			var item = GetMenuItem();
			var actionHasNotBeenTriggered = true ;
			_element.Action += (s, e) =>
				actionHasNotBeenTriggered = false;
			
			_element.Dispose();
			
			item.PerformClick();
			
			Assert.That(actionHasNotBeenTriggered);		
		}
		
		[Test]
		public void Dispose_removes_hyperlink_handler()
		{
			_element.AddTo(_panel);
			var item = GetHyperLink();
			var actionHasNotBeenTriggered = true ;
			_element.Action += (s, e) =>
				actionHasNotBeenTriggered = false;
			
			_element.Dispose();
			
			item.PerformClick();
			
			Assert.That(actionHasNotBeenTriggered);		
		}
	}
}