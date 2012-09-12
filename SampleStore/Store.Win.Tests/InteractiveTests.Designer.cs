
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
			CG.Controls.NavigationBar.Office2003NavigationBarRenderer office2003NavigationBarRenderer1 = new CG.Controls.NavigationBar.Office2003NavigationBarRenderer();
			CG.Controls.Grid.Buttons.OfficeButtonRenderer officeButtonRenderer1 = new CG.Controls.Grid.Buttons.OfficeButtonRenderer();
			this._mainTests = new CG.Controls.NavigationBar.ExPanel();
			this.exButton1 = new CG.Controls.Grid.Buttons.ExButton();
			this._mainTests.SuspendLayout();
			this.SuspendLayout();
			// 
			// _mainTests
			// 
			this._mainTests.BackColor = System.Drawing.Color.White;
			this._mainTests.Controls.Add(this.exButton1);
			this._mainTests.HeaderText = "Main Tests";
			this._mainTests.Location = new System.Drawing.Point(12, 1);
			this._mainTests.Name = "_mainTests";
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
			this._mainTests.Renderer = office2003NavigationBarRenderer1;
			this._mainTests.Size = new System.Drawing.Size(236, 396);
			this._mainTests.TabIndex = 0;
			this._mainTests.Text = "MainTests";
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
			this.exButton1.Text = "exButton1";
			this.exButton1.Click += new System.EventHandler(this.ExButton1Click);
			// 
			// InteractiveTests
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(935, 409);
			this.Controls.Add(this._mainTests);
			this.Name = "InteractiveTests";
			this.Text = "InteractiveTess";
			this._mainTests.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private CG.Controls.Grid.Buttons.ExButton exButton1;
		private CG.Controls.NavigationBar.ExPanel _mainTests;
	}
}
