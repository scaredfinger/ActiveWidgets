using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ActiveWidgets.Utils;
using CG.Controls.Grid.Buttons;
using CG.Controls.Grid.Forms;
using CG.Controls.NavigationBar;
using Store.Controls;
using Store.Domain;

namespace Store.Modules.Core
{
    /// <summary>
	/// UI Element implementation for main widget.
	/// </summary>
	public partial class MainControl : ExForm, IMainControl
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
		    CreateModulesMenu(model);
		}

	    private void CreateModulesMenu(MainViewModel model)
	    {
	        model.ModulesMenu
	            .OfType<MenuElementGroup>()
	            .ForEach(AddGroupToModulesBar);

            model.TopMenu
                .OfType<MenuElementGroup>()
                .ForEach(AddToTopMenu);

            model.Toolbar
                .OfType<MenuElement>()
                .ForEach(AddToolbarMenu);
	    }

	    private void AddGroupToModulesBar(MenuElementGroup moduleMenu)
		{
	    	moduleMenu.AddTo(_modulesBar);
		}

        private void AddToTopMenu(MenuElementGroup topMenu)
        {
            topMenu.AddTo(_topMenu);
        }

        private void AddToolbarMenu(MenuElement menuElement)
        {
            var item = _toolbar.Items.Add("", menuElement.Glyph.Medium);
            item.ToolTipText = menuElement.Tooltip;
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
			_rightLayout.Width = _mainLayout.ClientSize.Width - _modulesBar.Width ;
		}
	}
}
