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
		private ToolStripItem _menuItem ;
		private ExHyperlink _hyperLink ;
		private ToolStripItem _toolbarItem ;
		
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
			if (_menuItem != null)
				_menuItem.Enabled = false ;
			
			if(_toolbarItem != null)
				_toolbarItem.Enabled = false ;
			
			if (_hyperLink != null)
				_hyperLink.Enabled = false ;
		}
		
        /// <summary>
        /// Enables this menu item
        /// </summary>
		public void Enable()
		{
			if (_menuItem != null)
				_menuItem.Enabled = true ;
			
			if(_toolbarItem != null)
				_toolbarItem.Enabled = true ;
			
			if (_hyperLink != null)
				_hyperLink.Enabled = true ;			
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
	        _menuItem = subMenu.DropDownItems.Add(Caption);

	        _menuItem.ToolTipText = Tooltip;
	        _menuItem.Image = Glyph.GetSmall();	        
	        _menuItem.Click += ElementClicked;
	    }
	    
	    private void ElementClicked(object sender, EventArgs e)
	    {
	    	OnAction();
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
	    	_hyperLink = new ExHyperlink
	    	{
	    		Text = Caption,
	    		Image = Glyph.GetSmall()
	    	};
	    	_hyperLink.Click += ElementClicked;
	    	
	    	container.Controls.Add(_hyperLink);	    	
	    }
	    
	    /// <summary>
		/// Adds current element to specified toolbar. 
		/// </summary>
		/// <param name="menu">Toolbar to add this group to.</param>
	    public virtual void AddTo(ToolStrip toolbar)
	    {
	    	_toolbarItem = new ToolStripButton
	    	{
	    		Text = Caption,
	    		ToolTipText = Tooltip,
	    		Image = Glyph.GetMedium(),
	    		DisplayStyle = ToolStripItemDisplayStyle.Image
	    	};
	    	_toolbarItem.Click += ElementClicked;
	    	
	    	toolbar.Items.Add(_toolbarItem);
	    }
	}
}
