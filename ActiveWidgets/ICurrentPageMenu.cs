using System;
using System.Collections.Generic;
using ActiveWidgets.Controls;

namespace ActiveWidgets
{
	/// <summary>
	/// Manages menu items for current widget
	/// </summary>
	/// <seealso cref="IPages"/>
	public interface ICurrentPageMenu
	{
		/// <summary>
		/// Gets a collection of menu item controls for the current widget
		/// </summary>
		IEnumerable<IMenuElement> Items { get; }
	}
}
