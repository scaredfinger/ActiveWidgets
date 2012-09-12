using System.Linq;
using System.Collections.Generic;
using Store.Domain;
using Store.Modules.Core;

namespace Store.Win.Tests.Tests.Main
{
	/// <summary>
	/// Description of Create.
	/// </summary>
	public class Create : UiTest
	{		
		public override void Run()
		{
			var list = new List<MenuElementGroup>();
			for(var i = 0; i < 5; i ++)
				list.Add(new MenuElementGroup	
				{
				         	Caption = Random.Name(),
				         	Tooltip = Random.Sentence(),
				         	Glyph = Random.Glyph(),
				});
			
			var mainControl = new MainControl();
			mainControl.SetViewModel(
				new MainViewModel{
					ModulesMenu = list.Cast<IMenuElementGroup>()
				});
			
			mainControl.ShowDialog();
		}
	}
}
