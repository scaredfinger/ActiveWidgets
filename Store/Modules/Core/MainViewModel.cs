
using System;
using System.Collections.Generic;
using Store.Domain;

namespace Store.Modules.Core
{
	/// <summary>
	/// Represents the View Model for the Main widget
	/// </summary>
	public class MainViewModel
	{
		public IEnumerable<IModuleMenu> ModulesMenu { get; set; }
	}
}
