using System;
using System.Collections.Generic;
using ActiveWidgets.Controls;

namespace Store.Domain
{
	/// <summary>
	/// Holds information about a set of menu elements.
	/// </summary>
	public interface IMenuElementGroup
	{
		/// <summary>
		/// Gets or sets the caption.
		/// </summary>
		string Caption { get ; set ; }
		
		/// <summary>
		/// Gets or sets the toolip.
		/// </summary>
		string Tooltip { get; set; }
		
		/// <summary>
		/// Gets or sets a collection with the menu elements contained in this set.
		/// </summary>
		IEnumerable<IMenuElement> Options { get; set; }
	}
}
