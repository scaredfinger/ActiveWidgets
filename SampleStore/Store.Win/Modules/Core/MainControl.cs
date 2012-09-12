using System;
using System.Drawing;
using System.Windows.Forms;

using ActiveWidgets.Controls;
using ActiveWidgets.Utils;
using CG.Controls.Grid.Forms;
using CG.Controls.NavigationBar;
using Store.Domain;

namespace Store.Modules.Core
{
	/// <summary>
	/// Description of Main.
	/// </summary>
	public partial class MainControl : ExForm, IElement
	{
		public MainControl()
		{
			InitializeComponent();
		}
		
		public void Disable()
		{
			Enabled = false ;
		}
		
		public void Enable()
		{
			Enabled = true ;
		}
		
		public void SetViewModel(MainViewModel model)
		{
			model.ModulesMenu
				.ForEach(x => CreateModuleOption((MenuElementGroup)x));
		}
		
		public void CreateModuleOption(MenuElementGroup moduleMenu)
		{
			var groupImage = moduleMenu.Glyph.Medium ;
			var panel = new ExNavigationPanel{
				Text = moduleMenu.Caption,
				PanelImage = groupImage
			};
			
			
			_modulesBar.AddPanel(panel) ;
		}
		
		private void MainLayoutResized(object sender, EventArgs e)
		{
			_modulesBar.Height = _mainLayout.ClientSize.Height;
			_rightLayout.Height = _mainLayout.ClientSize.Height;
			
			UpdateMainLayoutSize();
		}
		
		private void ModulesBarExpandedChanged(object sender, EventArgs e)
		{
			UpdateMainLayoutSize();
		}
		
		private void UpdateMainLayoutSize(){
			_rightLayout.Width = _mainLayout.ClientSize.Width - 
				_modulesBar.Width ;
		}
	}
}
