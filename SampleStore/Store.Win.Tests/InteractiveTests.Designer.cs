
namespace Store.Win.Tests
{
	partial class InteractiveTests
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			CG.Controls.NavigationBar.ExPanel _mainTests;
			CG.Controls.NavigationBar.Office2003NavigationBarRenderer office2003NavigationBarRenderer1 = new CG.Controls.NavigationBar.Office2003NavigationBarRenderer();
			CG.Controls.Grid.Buttons.OfficeButtonRenderer officeButtonRenderer1 = new CG.Controls.Grid.Buttons.OfficeButtonRenderer();
			CG.Controls.NavigationBar.ExPanel exPanel1;
			CG.Controls.NavigationBar.Office2003NavigationBarRenderer office2003NavigationBarRenderer2 = new CG.Controls.NavigationBar.Office2003NavigationBarRenderer();
			CG.Controls.Grid.Buttons.ExButton exButton2;
			CG.Controls.Grid.Buttons.OfficeButtonRenderer officeButtonRenderer2 = new CG.Controls.Grid.Buttons.OfficeButtonRenderer();
			this.exButton1 = new CG.Controls.Grid.Buttons.ExButton();
			_mainTests = new CG.Controls.NavigationBar.ExPanel();
			exPanel1 = new CG.Controls.NavigationBar.ExPanel();
			exButton2 = new CG.Controls.Grid.Buttons.ExButton();
			_mainTests.SuspendLayout();
			exPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _mainTests
			// 
			_mainTests.BackColor = System.Drawing.Color.White;
			_mainTests.Controls.Add(this.exButton1);
			_mainTests.HeaderText = "Main Tests";
			_mainTests.Location = new System.Drawing.Point(12, 1);
			_mainTests.Name = "_mainTests";
			office2003NavigationBarRenderer1.BorderColor = System.Drawing.Color.DarkBlue;
			office2003NavigationBarRenderer1.ColorPreset = CG.Controls.Common.ColorPresetType.Blue;
			office2003NavigationBarRenderer1.HeaderColorFrom = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(131)))), ((int)(((byte)(211)))));
			office2003NavigationBarRenderer1.HeaderColorTo = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(55)))), ((int)(((byte)(156)))));
			office2003NavigationBarRenderer1.HeaderTextColor = System.Drawing.Color.White;
			office2003NavigationBarRenderer1.PanelBackColor = System.Drawing.Color.White;
			office2003NavigationBarRenderer1.PanelColorFrom = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
			office2003NavigationBarRenderer1.PanelColorTo = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
			office2003NavigationBarRenderer1.PanelOverColorFrom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(210)))));
			office2003NavigationBarRenderer1.PanelOverColorTo = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(106)))));
			office2003NavigationBarRenderer1.PanelSelectedColorFrom = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(223)))), ((int)(((byte)(137)))));
			office2003NavigationBarRenderer1.PanelSelectedColorTo = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(32)))));
			office2003NavigationBarRenderer1.PanelTextColor = System.Drawing.Color.Black;
			_mainTests.Renderer = office2003NavigationBarRenderer1;
			_mainTests.Size = new System.Drawing.Size(236, 396);
			_mainTests.TabIndex = 0;
			_mainTests.Text = "MainTests";
			// 
			// exButton1
			// 
			this.exButton1.BackColor = System.Drawing.Color.Transparent;
			this.exButton1.CornerRadius = 3;
			this.exButton1.DialogResult = System.Windows.Forms.DialogResult.None;
			this.exButton1.DrawFocusRect = true;
			this.exButton1.ImageOffset = new System.Drawing.Point(4, 0);
			this.exButton1.ImageSize = new System.Drawing.Size(16, 16);
			this.exButton1.IsSplitButton = false;
			this.exButton1.Location = new System.Drawing.Point(18, 37);
			this.exButton1.MetroColorScheme = CG.Controls.Grid.Render.MetroScheme.Orange;
			this.exButton1.Name = "exButton1";
			this.exButton1.PaddingText = new System.Windows.Forms.Padding(4);
			officeButtonRenderer1.TextColorDisabled = System.Drawing.SystemColors.GrayText;
			this.exButton1.Renderer = officeButtonRenderer1;
			this.exButton1.RenderType = CG.Controls.Common.EnRenderType.Office2007;
			this.exButton1.Size = new System.Drawing.Size(100, 23);
			this.exButton1.SplitButtonWidth = 20;
			this.exButton1.TabIndex = 0;
			this.exButton1.Text = "Main form";
			this.exButton1.Click += new System.EventHandler(this.MainForm);
			// 
			// exPanel1
			// 
			exPanel1.BackColor = System.Drawing.Color.White;
			exPanel1.Controls.Add(exButton2);
			exPanel1.HeaderText = "Other Tests";
			exPanel1.Location = new System.Drawing.Point(259, 1);
			exPanel1.Name = "exPanel1";
			office2003NavigationBarRenderer2.BorderColor = System.Drawing.Color.DarkBlue;
			office2003NavigationBarRenderer2.ColorPreset = CG.Controls.Common.ColorPresetType.Blue;
			office2003NavigationBarRenderer2.HeaderColorFrom = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(131)))), ((int)(((byte)(211)))));
			office2003NavigationBarRenderer2.HeaderColorTo = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(55)))), ((int)(((byte)(156)))));
			office2003NavigationBarRenderer2.HeaderTextColor = System.Drawing.Color.White;
			office2003NavigationBarRenderer2.PanelBackColor = System.Drawing.Color.White;
			office2003NavigationBarRenderer2.PanelColorFrom = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
			office2003NavigationBarRenderer2.PanelColorTo = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
			office2003NavigationBarRenderer2.PanelOverColorFrom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(210)))));
			office2003NavigationBarRenderer2.PanelOverColorTo = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(106)))));
			office2003NavigationBarRenderer2.PanelSelectedColorFrom = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(223)))), ((int)(((byte)(137)))));
			office2003NavigationBarRenderer2.PanelSelectedColorTo = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(32)))));
			office2003NavigationBarRenderer2.PanelTextColor = System.Drawing.Color.Black;
			exPanel1.Renderer = office2003NavigationBarRenderer2;
			exPanel1.Size = new System.Drawing.Size(236, 396);
			exPanel1.TabIndex = 1;
			exPanel1.Text = "Other Tests";
			// 
			// exButton2
			// 
			exButton2.BackColor = System.Drawing.Color.Transparent;
			exButton2.CornerRadius = 3;
			exButton2.DialogResult = System.Windows.Forms.DialogResult.None;
			exButton2.DrawFocusRect = true;
			exButton2.ImageOffset = new System.Drawing.Point(4, 0);
			exButton2.ImageSize = new System.Drawing.Size(16, 16);
			exButton2.IsSplitButton = false;
			exButton2.Location = new System.Drawing.Point(18, 37);
			exButton2.MetroColorScheme = CG.Controls.Grid.Render.MetroScheme.Orange;
			exButton2.Name = "exButton2";
			exButton2.PaddingText = new System.Windows.Forms.Padding(4);
			officeButtonRenderer2.TextColorDisabled = System.Drawing.SystemColors.GrayText;
			exButton2.Renderer = officeButtonRenderer2;
			exButton2.RenderType = CG.Controls.Common.EnRenderType.Office2007;
			exButton2.Size = new System.Drawing.Size(100, 23);
			exButton2.SplitButtonWidth = 20;
			exButton2.TabIndex = 0;
			exButton2.Text = "Stack panel";
			exButton2.Click += new System.EventHandler(this.StackPanel);
			// 
			// InteractiveTests
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(935, 409);
			this.Controls.Add(exPanel1);
			this.Controls.Add(_mainTests);
			this.Name = "InteractiveTests";
			this.Text = "InteractiveTess";
			_mainTests.ResumeLayout(false);
			exPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private CG.Controls.Grid.Buttons.ExButton exButton1;
	}
}
