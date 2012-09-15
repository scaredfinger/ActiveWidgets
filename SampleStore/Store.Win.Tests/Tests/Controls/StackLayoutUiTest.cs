
using System;
using System.Windows.Forms;
using CG.Controls.Grid.Buttons;
using Store.Controls;

namespace Store.Win.Tests.Tests.Controls
{
	public class StackLayoutUiTest: UiTest
	{
		public override void Run()
		{
			var form = new Form();
			var stackPanel = new StackPanel{
				Dock = DockStyle.Fill
			};
			form.Controls.Add(stackPanel) ;
			
			for(var i = 0; i < 50; i++)
			{
				var button = new ExButton(){
					Text = Random.Name(),
					Image = Random.Image16x16()
				};
				
				stackPanel.Controls.Add(button) ;
				
				var hyperlink = new ExHyperlink()
				{
					Text = Random.Name(),
					Image = Random.Image16x16()
				};
				
				stackPanel.Controls.Add(hyperlink) ;
			}
			
			form.ShowDialog();
		}
	}
}
