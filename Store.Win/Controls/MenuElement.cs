using System;
using System.Drawing;
using System.Windows.Forms;
using ActiveWidgets.Controls;

namespace Store.Win.Controls
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class MenuElement : IMenuElement
	{
		/// <summary>
		/// Gets the caption for this menu item
		/// </summary>
		public string Caption { get; private set; }
		
		/// <summary>
		/// Gets the tooltip for this menu item
		/// </summary>
		public string Tooltip { get; private set; }
		
		/// <summary>
		/// Gets the glyph for this menu item
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
	}
}
