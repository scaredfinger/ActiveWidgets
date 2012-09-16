
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
			this._testsPanel = new Store.Controls.StackPanel();
			this._modules = new System.Windows.Forms.ComboBox();
			this._output = new System.Windows.Forms.TextBox();
			this._actions = new Store.Controls.StackPanel();
			_mainTests = new CG.Controls.NavigationBar.ExPanel();
			_mainTests.SuspendLayout();
			this.SuspendLayout();
			// 
			// _mainTests
			// 
			_mainTests.BackColor = System.Drawing.Color.White;
			_mainTests.Controls.Add(this._testsPanel);
			_mainTests.HeaderText = "Tests";
			_mainTests.Location = new System.Drawing.Point(12, 45);
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
			_mainTests.Size = new System.Drawing.Size(236, 352);
			_mainTests.TabIndex = 0;
			_mainTests.Text = "Tests";
			// 
			// _testsPanel
			// 
			this._testsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._testsPanel.Location = new System.Drawing.Point(1, 25);
			this._testsPanel.Name = "_testsPanel";
			this._testsPanel.Size = new System.Drawing.Size(234, 326);
			this._testsPanel.TabIndex = 2;
			// 
			// _modules
			// 
			this._modules.FormattingEnabled = true;
			this._modules.Location = new System.Drawing.Point(13, 12);
			this._modules.Name = "_modules";
			this._modules.Size = new System.Drawing.Size(235, 21);
			this._modules.TabIndex = 2;
			this._modules.SelectedIndexChanged += new System.EventHandler(this.ModuleSelected);
			// 
			// _output
			// 
			this._output.Location = new System.Drawing.Point(419, 12);
			this._output.Multiline = true;
			this._output.Name = "_output";
			this._output.Size = new System.Drawing.Size(504, 384);
			this._output.TabIndex = 4;
			// 
			// _actions
			// 
			this._actions.Location = new System.Drawing.Point(254, 12);
			this._actions.Name = "_actions";
			this._actions.Size = new System.Drawing.Size(159, 384);
			this._actions.TabIndex = 5;
			// 
			// InteractiveTests
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(935, 409);
			this.Controls.Add(this._actions);
			this.Controls.Add(this._output);
			this.Controls.Add(this._modules);
			this.Controls.Add(_mainTests);
			this.Name = "InteractiveTests";
			this.Text = "InteractiveTess";
			_mainTests.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private Store.Controls.StackPanel _actions;
		private System.Windows.Forms.TextBox _output;
		private Store.Controls.StackPanel _testsPanel;
		private System.Windows.Forms.ComboBox _modules;
	}
}
