using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ActiveWidgets.Controls;
using ActiveWidgets.Utils;
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
	    public void AddTo(MenuStrip mainMenu)
        {
            var menu = new ToolStripMenuItem(Caption);
            if (Glyph != null)
                menu.Image = Glyph.Small;
            menu.ToolTipText = Tooltip;

            mainMenu.Items.Add(menu);

            Options
                .OfType<MenuElement>()
                .ForEach(element => AddToMenu(element, menu));
        }
        private static void AddToMenu(MenuElement menuElement, ToolStripDropDownItem menu)
        {
            var item = menu.DropDownItems.Add(menuElement.Caption, menuElement.Glyph.Small);
            item.ToolTipText = menuElement.Tooltip;
        }
	}
}
