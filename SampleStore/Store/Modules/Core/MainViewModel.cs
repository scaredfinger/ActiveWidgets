using System.Collections.Generic;
using ActiveWidgets.Controls;
using Store.Domain;

namespace Store.Modules.Core
{
	/// <summary>
	/// Represents the View Model for the Main widget
	/// </summary>
	public class MainViewModel
	{
        /// <summary>
        /// Gets or sets the toolbar to show in main screen
        /// </summary>
	    public IEnumerable<IMenuElement> Toolbar { get; set; }

        /// <summary>
        /// Gets or sets the top menu
        /// </summary>
	    public IEnumerable<IMenuElementGroup> TopMenu { get; set; }

        /// <summary>
        /// Gets or sets the modules menu
        /// </summary>
	    public IEnumerable<IMenuElementGroup> ModulesMenu { get; set; }
	}
}
