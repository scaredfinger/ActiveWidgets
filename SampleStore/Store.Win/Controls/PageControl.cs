using System;
using System.Drawing;
using System.Windows.Forms;

using Store.Resources;

namespace Store.Win.Controls
{
	/// <summary>
	/// Description of PageControl.
	/// </summary>
	public class PageControl : UserControl
	{
		/// <summary>
		/// Gets the title for this page
		/// </summary>
		public virtual string Title 
		{
			get
			{
				return Text ;
			}
		}
		
		/// <summary>
		/// Gets the glyph for this page
		/// </summary>
		public virtual Glyph Glyph 
		{ 
			get 
			{
				return new Glyph(Icons16.app, Icons32.app, Icons48.app) ;
			} 
		}
	}
}
