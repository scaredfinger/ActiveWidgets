using Store.Modules.Core;

namespace Store.Win.Tests.Tests.Main
{
	public class SetCurrentPage : UiTest
	{
		public override string Name {
			get {
				return "Set current page";	
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
			
			mainControl.Show();
		}	
	}
}
