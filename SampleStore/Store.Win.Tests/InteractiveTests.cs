using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ActiveWidgets.Utils;
using CG.Controls.Grid.Buttons;
using CG.Controls.Grid.Forms;
using Store.Domain;
using Store.Modules.Core;
using Store.Win.Tests.Tests;
using Store.Win.Tests.Tests.Controls;
using Store.Win.Tests.Tests.Main;

namespace Store.Win.Tests
{
	/// <summary>
	/// Description of InteractiveTess.
	/// </summary>
	public partial class InteractiveTests : ExForm
	{
		private readonly HashSet<string> _moduleNames = new HashSet<string>();
		
		private readonly IList<UiTest> _tests ;
		
		public InteractiveTests()
		{
			InitializeComponent();
			
			_tests = AllTypes.InCurrentAssembly()
				.Where(x => x.IsConcrete() && x.IsAssignableTo<UiTest>())
				.Select(x => (UiTest)Activator.CreateInstance(x))
				.ToList();
			
			_tests
				.ForEach(x => x.Owner = this);
			
			_tests.Select(x => x.Module)
				.Distinct()
				.ForEach(x => _moduleNames.Add(x));
			
			_modules.DataSource = _moduleNames.ToList() ;
		}
						
		void ModuleSelected(object sender, EventArgs e)
		{
			_testsPanel.Controls.Clear();
			
			var selected = (string)_modules.SelectedValue ;
			var moduleTests = _tests.Where(x => x.Module == selected);
			
			moduleTests.ForEach(x => AddLinkTo(x));
		}
		
		void AddLinkTo(UiTest test)
		{
			var link = new ExHyperlink{
				Text = test.Name
			};
			
			link.Click += (s, e) => 
				TestLinkClicked(test);
			
			_testsPanel.Controls.Add(link) ;
		}
		
		private void TestLinkClicked(UiTest test)
		{
			_actions.Controls.Clear();
			
			test.Actions
				.ForEach(x => _actions.Controls.Add(x));
			
			test.Run();
		}
		
		public void Notify(string text)
		{
			_output.Text += text ;
			_output.Select(_output.Text.Length - 1, 0);
		}
		
		public void Notify(string text, params object[] args)
		{
			Notify(string.Format(text, args));
		}
	}
}
