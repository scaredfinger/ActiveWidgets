using System;
using System.Windows.Forms;
using ActiveWidgets.Controls;
using CG.Controls.Grid.Buttons;
using CG.Controls.NavigationBar;
using StackPanel = Store.Controls.StackPanel;

namespace Store.Controls
{
    /// <summary>
    /// Represents an adapter for actual toolbar items. Toolbar items are only known to the 
    /// ui elements. So we must provide a mechanism to hide them to the application logic layer.
    /// </summary>
	/// <remarks>
	/// This is the winforms / GF Grid specific implementation. Use the <see cref="AddTo"/>
	/// overloads to add a group to different parts of main widget.
	/// </remarks>
	public class MenuElement : IMenuElement
	{
		/// <summary>
		/// Gets the caption for this menu element.
		/// </summary>
		public string Caption { get; private set; }
		
		/// <summary>
		/// Gets the tooltip for this menu element.
		/// </summary>
		public string Tooltip { get; private set; }
		
		/// <summary>
		/// Gets the glyph for this menu element
		/// </summary>
		public Glyph Glyph { get; private set; }
		
		/// <summary>
		/// Creates an instance
		/// </summary>
		/// <param name="caption">Specifies the caption for this menu item</param>
		/// <param name="tooltip">Specifies the tooltip for this menu item</param>
		/// <param name="glyph">Specifies the glyph for this menu item</param>
		public MenuElement(string caption, string tooltip, Glyph glyph)
		{
			Caption = caption ;
			Tooltip = tooltip ;
			Glyph = glyph ;
		}
		
		/// <summary>
		/// Creates an instance
		/// </summary>
		public MenuElement()
		{
		
		}
				
        /// <summary>
        /// Disables this menu item
        /// </summary>
		public void Disable()
		{
			
		}
		
        /// <summary>
        /// Enables this menu item
        /// </summary>
		public void Enable()
		{
			
		}
        
        /// <summary>
        /// Notifies the item has been actioned, e.g. Clicked
        /// </summary>
		public event EventHandler Action;
		
		private void OnAction()
		{
			if (Action != null)
				Action(this, EventArgs.Empty);
		}

		/// <summary>
		/// Adds current element to specified menu item.
		/// </summary>
		/// <param name="menu">Menu item to add this group to.</param>
	    public virtual void AddTo(ToolStripMenuItem subMenu)
	    {
	        var item = subMenu.DropDownItems.Add(Caption);

	        item.ToolTipText = Tooltip;
	        item.Image = Glyph.GetSmall();
	    }
	    
		/// <summary>
		/// Adds current element as a hyperlink to specified panel. 
		/// </summary>
		/// <remarks>
		/// It is recomended to use automatic layout panels, such as <see cref="FlowLayoutPanel"/> 
		/// or <see cref="StackPanel"/>.
		/// </remarks>
		/// <param name="menu">Panel to add this group to.</param>
	    public virtual void AddTo(Panel container)
	    {
	    	var hyperlink = new ExHyperlink
	    	{
	    		Text = Caption,
	    		Image = Glyph.GetSmall()
	    	};
	    	container.Controls.Add(hyperlink);
	    }
	    
	    
		/// <summary>
		/// Adds current element to specified toolbar. 
		/// </summary>
		/// <param name="menu">Toolbar to add this group to.</param>
	    public virtual void AddTo(ToolStrip toolbar)
	    {
	    	var item = new ToolStripButton
	    	{
	    		Text = Caption,
	    		ToolTipText = Tooltip,
	    		Image = Glyph.GetSmall()
	    	};
	    	
	    	toolbar.Items.Add(item);
	    }
	}
}
