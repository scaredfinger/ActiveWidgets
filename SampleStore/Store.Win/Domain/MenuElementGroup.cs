using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using ActiveWidgets.Controls;
using ActiveWidgets.Utils;
using CG.Controls.NavigationBar;
using Store.Controls;

namespace Store.Domain
{
	/// <summary>
	/// Holds information about a set of menu elements.
	/// </summary>
	/// <remarks>
	/// This is the winforms / GF Grid specific implementation. Use the <see cref="AddTo"/>
	/// overloads to add a group to different parts of main widget.
	/// </remarks>
	public class MenuElementGroup : IMenuElementGroup
	{
		/// <summary>
		/// Gets or sets the caption.
		/// </summary>
		public string Caption { get ; set ; }
		
		/// <summary>
		/// Gets or sets the toolip.
		/// </summary>
		public string Tooltip { get ; set; }
		
		/// <summary>
		/// Gets or sets the glyph that represents this set.
		/// </summary>
		public Glyph Glyph { get; set; }
		
		/// <summary>
		/// Gets or sets a collection with the menu elements contained in this set.
		/// </summary>
		public IEnumerable<IMenuElement> Options { get; set; }

		/// <summary>
		/// Adds current element group to specified menu strip.
		/// </summary>
		/// <param name="menu">Menu strip to add this group to.</param>
		public virtual void AddTo(MenuStrip menu)
		{
			var menuItem = NewMenuItem();
			menu.Items.Add(menuItem);

			CreateItemsForOptions(menuItem);
		}

		private ToolStripMenuItem NewMenuItem()
		{
			return new ToolStripMenuItem(Caption)
			{
				Image = Glyph.GetSmall(),
				ToolTipText = Tooltip
			};
		}

		private void CreateItemsForOptions(ToolStripMenuItem menuItem)
		{
			MenuElementOptions()
				.ForEach(element => element.AddTo(menuItem));
		}
		
		private IEnumerable<MenuElement> MenuElementOptions()
		{
			return Options == null
				? new MenuElement[0]
				: Options.OfType<MenuElement>();
		}
		
		/// <summary>
		/// Adds current element group to specified navigation bar.
		/// </summary>
		/// <param name="bar">Navigation bar to add this group to.</param>
		public void AddTo(ExNavigationBar bar)
		{
			var container = NewStackPanel();
			AddContainerToNavBar(container, bar);
			
			MenuElementOptions()
				.ForEach(option => option.AddTo(container));
		}

		private static StackPanel NewStackPanel()
		{
			return new StackPanel {
				Dock = DockStyle.Fill,
				Padding = new Padding(10)
			};
		}

		private void AddContainerToNavBar(StackPanel container, ExNavigationBar bar)
		{
			var panel = new ExNavigationPanel {
				Text = Caption,
				PanelImage = Glyph.GetMedium()
			};
			bar.AddPanel(panel);
			panel.Controls.Add(container);
		}
	}
}
