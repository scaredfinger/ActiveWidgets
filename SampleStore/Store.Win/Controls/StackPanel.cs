using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.ComponentModel;

namespace Store.Controls
{
	/// <summary>
	/// A panel which stacks child controls and resizes them to fill the panel width.
	/// </summary>
	public class StackPanel : Panel
	{
		private static readonly StackLayoutEngine _layoutEngine = new StackLayoutEngine();
		
		/// <summary>
		/// Creates an instance
		/// </summary>
	    public StackPanel()
	    {
	        base.AutoScroll = true;
	    }
	
	    /// <summary>
	    /// Hides parent autoscroll to replace it with an autoscroll enabled by default
	    /// property.
	    /// </summary>
	    [DefaultValue(true)]
	    public new bool AutoScroll
	    {
	        get { return base.AutoScroll; }
	        set { base.AutoScroll = value; }
	    }
	
	    /// <summary>
	    /// Overrides the default layout engine to use a <see cref="StackLayoutEngine"/>.
	    /// </summary>
	    public override LayoutEngine LayoutEngine
	    {
	        get
	        {
	            return _layoutEngine;
	        }
	    }
	}
}
