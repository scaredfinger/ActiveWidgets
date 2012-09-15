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
	/// Description of ModuleMenu.
	/// </summary>
	public class MenuElementGroup : IMenuElementGroup
	{
		public string Caption { get ; set ; }
		
		public string Tooltip { get ; set; }
		
		public Glyph Glyph { get; set; }
		
		public IEnumerable<IMenuElement> Options { get; set; }

		/// <summary>
		/// Adds currrent element group to specified menu strip
		/// </summary>
		/// <param name="mainMenu"></param>
		public virtual void AddTo(MenuStrip mainMenu)
		{
			var menuItem = NewMenuItem();
			mainMenu.Items.Add(menuItem);

			CreateItemsForOptions(menuItem);
		}

		private ToolStripMenuItem NewMenuItem()
		{
			return new ToolStripMenuItem(Caption)
			{
				Image = Glyph == null ? null : Glyph.Small,
				ToolTipText = Tooltip
			};
		}

		private void CreateItemsForOptions(ToolStripMenuItem menuItem)
		{
			if (Options == null) return;

			Options
				.OfType<MenuElement>()
				.ForEach(element => element.AddTo(menuItem));
		}
		
		public void AddTo(ExNavigationBar bar)
		{
			ExNavigationPanel panel = NewNavigationPanel();
			bar.AddPanel(panel);
			
			if (Options == null) return;
		
			Options
				.OfType<MenuElement>()
				.ForEach(option => option.AddTo(panel.Controls[0] as Panel));
		}

		private ExNavigationPanel NewNavigationPanel()
		{
			var result = new ExNavigationPanel {
				Text = Caption,
				PanelImage = Glyph == null ? null : Glyph.Medium
			};
			
			var flowPanel = new FlowLayoutPanel{
				Dock = DockStyle.Fill,
                Padding = new Padding(10)
			};
			
			result.Controls.Add(flowPanel) ;
			
			return result ;
		}
	}
}
