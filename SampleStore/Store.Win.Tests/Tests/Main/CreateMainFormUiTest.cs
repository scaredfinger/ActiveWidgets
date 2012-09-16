using Store.Modules.Core;

namespace Store.Win.Tests.Tests.Main
{
	public class CreateMainFormUiTest : UiTest
	{		
		public override string Name {
			get {
				return "Create instance" ;
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
					ModulesMenu = CreateMenuElementGroup(),
                    TopMenu = CreateMenuElementGroup(),
                    Toolbar = CreateMenuElements()
				});
			
			mainControl.Show();
		}
	}
}
