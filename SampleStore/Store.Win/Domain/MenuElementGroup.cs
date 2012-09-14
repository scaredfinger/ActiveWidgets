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
	}
}
