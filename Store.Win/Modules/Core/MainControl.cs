using System;
using System.Drawing;
using System.Windows.Forms;

using ActiveWidgets.Controls;

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
		
		}
	}
}
