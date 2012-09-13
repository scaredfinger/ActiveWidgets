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
		    var mainControl = new MainControl();
			mainControl.SetViewModel(
				new MainViewModel{
					ModulesMenu = CreateMenuElementGroup(),
                    TopMenu = CreateMenuElementGroup()
				});
			
			mainControl.ShowDialog();
		}
	}
}
