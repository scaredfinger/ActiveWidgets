
using System;
using System.Collections.Generic;
using ActiveWidgets.Controls;
using ActiveWidgets.Utils;
using Store.Domain;
using Store.Modules.Core;

namespace Store.Win.Tests.Tests.Main
{
	public class DisableAndEnableButtons : UiTest
	{
		private readonly IEnumerable<IMenuElementGroup> _modules ;
		private readonly IEnumerable<IMenuElement> _toolbar ;
		
		public DisableAndEnableButtons()
		{
			_modules = CreateMenuElementGroup() ;
			_toolbar = CreateMenuElements();
			
			AddAction("Enable Toolbar", () => 
			          _toolbar.ForEach(x => x.Enable()));
			AddAction("Disable Toolbar", () => 
			          _toolbar.ForEach(x => x.Disable()));
		}
		
		public override string Name {
			get {
				return "Enable/Disable links" ;
			}
		}	
		
		public override string Module {
			get {
				return "Main";
			}			
		}
		
		public override void Run()
		{
		    var mainControl = new MainControl();
			mainControl.SetViewModel(
				new MainViewModel{
					ModulesMenu = _modules,
                    TopMenu = _modules,
                    Toolbar = _toolbar
				});
			
			mainControl.Show();
		}
	}
}
