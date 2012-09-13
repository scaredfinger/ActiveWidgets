using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ActiveWidgets.Controls;
using ActiveWidgets.Utils;
using CG.Controls.Grid.Buttons;
using CG.Controls.Grid.Forms;
using CG.Controls.NavigationBar;
using Store.Domain;
using Store.Win.Controls;

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

	    public void AddGroupToModulesBar(MenuElementGroup moduleMenu)
		{
			var groupImage = moduleMenu.Glyph.Medium ;
			var panel = NewNavigationPanel(moduleMenu, groupImage);
			_modulesBar.AddPanel(panel) ;

		    var buttons = NewFlowLayoutPanel();
            panel.Controls.Add(buttons);
            moduleMenu.Options
                .OfType<MenuElement>()
                .ForEach(x => AddButtonToPanel(x, buttons));
		}

	    private static ExNavigationPanel NewNavigationPanel(IMenuElementGroup moduleMenu, Image groupImage)
	    {
	        return new ExNavigationPanel
	                   {
	                       Text = moduleMenu.Caption,
	                       PanelImage = groupImage
	                   };
	    }

        private static FlowLayoutPanel NewFlowLayoutPanel()
        {
            var flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };
            return flowLayoutPanel;
        }

	    private void AddButtonToPanel(MenuElement menuElement, Control flowLayoutPanel)
	    {
	        var button = NewButton(menuElement);

            flowLayoutPanel.Controls.Add(button);
	    }

	    private ExButton NewButton(MenuElement menuElement)
	    {
	        return new ExButton
	                   {
	                       Width = _modulesBar.ClientSize.Width - 30,
	                       Text = menuElement.Caption,
	                       Image = menuElement.Glyph.Small,
	                       TextAlign = ContentAlignment.MiddleLeft
	                   };
	    }

        private void AddToTopMenu(MenuElementGroup topMenu)
        {
            var menu = new ToolStripMenuItem(topMenu.Caption);
            if (topMenu.Glyph != null)
                menu.Image = topMenu.Glyph.Small;
            menu.ToolTipText = topMenu.Tooltip;

            _topMenu.Items.Add(menu);

            topMenu.Options
                .OfType<MenuElement>()
                .ForEach(x => AddToMenu(x, menu));
        }

	    private void AddToMenu(MenuElement menuElement, ToolStripMenuItem menu)
	    {
	        menu.DropDownItems.Add(menuElement.Caption, menuElement.Glyph.Small);
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
