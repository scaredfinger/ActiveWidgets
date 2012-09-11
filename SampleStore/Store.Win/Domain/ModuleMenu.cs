using System;
using System.Collections.Generic;
using ActiveWidgets.Controls;
using Store.Win.Controls;

namespace Store.Domain
{
	/// <summary>
	/// Description of ModuleMenu.
	/// </summary>
	public class ModuleMenu : IModuleMenu
	{
		public string Caption { get ; set ; }
		
		public string Tooltip { get ; set; }
		
		public Glyph Glyph { get; set; }
		
		public IEnumerable<IMenuElement> Options { get; set; }
	}
}
