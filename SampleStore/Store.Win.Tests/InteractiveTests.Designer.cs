
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
			this._mainGroup = new System.Windows.Forms.GroupBox();
			this._mainLayout = new System.Windows.Forms.FlowLayoutPanel();
			this._mainButton = new VIBlend.WinForms.Controls.vButton();
			this._mainGroup.SuspendLayout();
			this._mainLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// _mainGroup
			// 
			this._mainGroup.Controls.Add(this._mainLayout);
			this._mainGroup.Location = new System.Drawing.Point(12, 12);
			this._mainGroup.Name = "_mainGroup";
			this._mainGroup.Size = new System.Drawing.Size(200, 385);
			this._mainGroup.TabIndex = 1;
			this._mainGroup.TabStop = false;
			this._mainGroup.Text = "Main";
			// 
			// _mainLayout
			// 
			this._mainLayout.Controls.Add(this._mainButton);
			this._mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this._mainLayout.Location = new System.Drawing.Point(3, 16);
			this._mainLayout.Name = "_mainLayout";
			this._mainLayout.Size = new System.Drawing.Size(194, 366);
			this._mainLayout.TabIndex = 1;
			// 
			// _mainButton
			// 
			this._mainButton.AllowAnimations = true;
			this._mainButton.BackColor = System.Drawing.Color.Transparent;
			this._mainButton.Location = new System.Drawing.Point(3, 3);
			this._mainButton.Name = "_mainButton";
			this._mainButton.RoundedCornersMask = ((byte)(15));
			this._mainButton.Size = new System.Drawing.Size(188, 30);
			this._mainButton.TabIndex = 0;
			this._mainButton.Text = "Main";
			this._mainButton.UseVisualStyleBackColor = false;
			this._mainButton.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
			this._mainButton.Click += new System.EventHandler(this.Main);
			// 
			// InteractiveTests
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(935, 409);
			this.Controls.Add(this._mainGroup);
			this.Name = "InteractiveTests";
			this.Text = "InteractiveTess";
			this._mainGroup.ResumeLayout(false);
			this._mainLayout.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private VIBlend.WinForms.Controls.vButton _mainButton;
		private System.Windows.Forms.FlowLayoutPanel _mainLayout;
		private System.Windows.Forms.GroupBox _mainGroup;
	}
}
