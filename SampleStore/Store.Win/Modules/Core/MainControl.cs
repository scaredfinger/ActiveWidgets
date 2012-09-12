using System;
using System.Drawing;
using System.Windows.Forms;

using ActiveWidgets.Controls;
using ActiveWidgets.Utils;
using Store.Domain;
using VIBlend.WinForms.Controls;

namespace Store.Modules.Core
{
	/// <summary>
	/// Description of Main.
	/// </summary>
	public partial class MainControl : Form, IElement
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
			var item = new vNavPaneItem
			{
				Text = moduleMenu.Caption,
				TooltipText = moduleMenu.Tooltip,
				Image = groupImage
			};
			
			//item.HeaderHeight = groupImage.Height + 7;
			
			_modules.Items.Add(item) ;
		}
	}
}
