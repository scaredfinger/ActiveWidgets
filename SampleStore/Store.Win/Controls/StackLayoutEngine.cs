using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.ComponentModel;

namespace Store.Controls
{
	/// <summary>
	/// Layout engine used by <see cref="StackPanel"/>.
	/// </summary>
	public class StackLayoutEngine : LayoutEngine
	{	
		/// <summary>
		/// Overrides default layout with stack behavior
		/// </summary>
		/// <param name="container">The container on which the layout engine will operate.</param>
		/// <param name="args">An event argument from a Layout event.</param>
		/// <returns>true if layout should be performed again by the parent of container; otherwise, false.</returns>
	    public override bool Layout(object container, LayoutEventArgs args)
	    {
	        StackPanel stackPanel = container as StackPanel;
	        if (stackPanel == null)
	            return false;
	
	        // Use DisplayRectangle so that parent.Padding is honored.
	        Rectangle displayRectangle = stackPanel.DisplayRectangle;
	        Point nextControlLocation = displayRectangle.Location;
	
	        foreach (Control control in stackPanel.Controls)
	        {
	            // Only apply layout to visible controls
	            if (control.Visible == false)
	                continue;
	
	            // Respect the margin of the control: shift over the left and the top.
	            nextControlLocation.Offset(control.Margin.Left, control.Margin.Top);
	
	            // Adjust control's Location and Size
	            control.Location = nextControlLocation;
	            Size size = control.GetPreferredSize(displayRectangle.Size);
	            if (!control.AutoSize)
	                size.Width = displayRectangle.Width - control.Margin.Left - control.Margin.Right;
	            control.Size = size;
	
	            // Move X back to the display rectangle origin.
	            nextControlLocation.X = displayRectangle.X;
	
	            // Increment Y by the height of the control and the bottom margin.
	            nextControlLocation.Y += control.Height + control.Margin.Bottom;
	        }
	
	        // Adjust width of control to accomodate vertical scrollbar if necessary
	        if (stackPanel.AutoScroll && nextControlLocation.Y > displayRectangle.Height)
	        {
	            displayRectangle.Width -= SystemInformation.VerticalScrollBarWidth;
	            foreach (Control control in stackPanel.Controls)
	            {
	                if (control.Visible)
	                {
	                    Size size = control.GetPreferredSize(displayRectangle.Size);
	                    if (!control.AutoSize)
	                        size.Width = displayRectangle.Width - control.Margin.Left - control.Margin.Right;
	                    control.Size = size;
	                }
	            }
	        }
	
	        return false;
	    }
	}
}
