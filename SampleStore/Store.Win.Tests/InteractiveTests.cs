
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using Store.Domain;
using Store.Modules.Core;
using Store.Win.Tests.Tests.Main;

namespace Store.Win.Tests
{
	/// <summary>
	/// Description of InteractiveTess.
	/// </summary>
	public partial class InteractiveTests : Form
	{
		public InteractiveTests()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Main(object sender, EventArgs e)
		{
			var create = new Create();
			create.Run();
		}
	}
}
