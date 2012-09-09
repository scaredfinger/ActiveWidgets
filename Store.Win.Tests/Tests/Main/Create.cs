
using System;
using System.Linq;
using System.Collections.Generic;
using Store.Domain;
using Store.Modules.Core;

namespace Store.Win.Tests.Tests.Main
{
	/// <summary>
	/// Description of Create.
	/// </summary>
	public class Create : Test
	{		
		public override void Run()
		{
			var list = new List<ModuleMenu>();
			for(var i = 0; i < 5; i ++)
				list.Add(new ModuleMenu	
				{
				         	Caption = Random.Name(),
				         	Tooltip = Random.Sentence(),
				         	Glyph = Random.Glyph(),
				});
			
			var mainControl = new MainControl();
			mainControl.SetViewModel(
				new MainViewModel{
					ModulesMenu = list.Cast<IModuleMenu>()
				});
			
			mainControl.ShowDialog();
		}
	}
}
