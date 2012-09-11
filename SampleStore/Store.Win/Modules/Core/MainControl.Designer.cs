
namespace Store.Modules.Core
{
	partial class MainControl
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
			this._status = new System.Windows.Forms.StatusStrip();
			this._topMenu = new System.Windows.Forms.MenuStrip();
			this._toolbar = new System.Windows.Forms.ToolStrip();
			this._splitContainer = new System.Windows.Forms.SplitContainer();
			this._modules = new VIBlend.WinForms.Controls.vNavPane();
			this.vNavPaneItem1 = new VIBlend.WinForms.Controls.vNavPaneItem();
			this._splitContainer.Panel1.SuspendLayout();
			this._splitContainer.SuspendLayout();
			this._modules.SuspendLayout();
			this.vNavPaneItem1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _status
			// 
			this._status.Location = new System.Drawing.Point(0, 385);
			this._status.Name = "_status";
			this._status.Size = new System.Drawing.Size(569, 22);
			this._status.TabIndex = 0;
			this._status.Text = "_status";
			// 
			// _topMenu
			// 
			this._topMenu.Location = new System.Drawing.Point(0, 0);
			this._topMenu.Name = "_topMenu";
			this._topMenu.Size = new System.Drawing.Size(569, 24);
			this._topMenu.TabIndex = 1;
			// 
			// _toolbar
			// 
			this._toolbar.Location = new System.Drawing.Point(0, 24);
			this._toolbar.Name = "_toolbar";
			this._toolbar.Size = new System.Drawing.Size(569, 25);
			this._toolbar.TabIndex = 3;
			// 
			// _splitContainer
			// 
			this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this._splitContainer.Location = new System.Drawing.Point(0, 49);
			this._splitContainer.Name = "_splitContainer";
			// 
			// _splitContainer.Panel1
			// 
			this._splitContainer.Panel1.Controls.Add(this._modules);
			this._splitContainer.Size = new System.Drawing.Size(569, 336);
			this._splitContainer.SplitterDistance = 189;
			this._splitContainer.TabIndex = 4;
			// 
			// _modules
			// 
			this._modules.Controls.Add(this.vNavPaneItem1);
			this._modules.Dock = System.Windows.Forms.DockStyle.Fill;
			this._modules.Items.Add(this.vNavPaneItem1);
			this._modules.Location = new System.Drawing.Point(0, 0);
			this._modules.Name = "_modules";
			this._modules.Size = new System.Drawing.Size(189, 336);
			this._modules.TabIndex = 2;
			this._modules.ToolTipDuration = 10000;
			this._modules.ToolTipShowDelay = 800;
			this._modules.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.EXPRESSIONDARK;
			// 
			// vNavPaneItem1
			// 
			this.vNavPaneItem1.BackColor = System.Drawing.Color.White;
			this.vNavPaneItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.vNavPaneItem1.HeaderHeight = 52;
			this.vNavPaneItem1.HeaderText = "Header";
			this.vNavPaneItem1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// vNavPaneItem1.ItemPanel
			// 
			this.vNavPaneItem1.ItemPanel.AutoScroll = true;
			this.vNavPaneItem1.ItemPanel.Location = new System.Drawing.Point(1, 52);
			this.vNavPaneItem1.ItemPanel.Name = "ItemPanel";
			this.vNavPaneItem1.ItemPanel.Size = new System.Drawing.Size(187, 283);
			this.vNavPaneItem1.ItemPanel.TabIndex = 1;
			this.vNavPaneItem1.Location = new System.Drawing.Point(0, 0);
			this.vNavPaneItem1.Name = "vNavPaneItem1";
			this.vNavPaneItem1.Size = new System.Drawing.Size(189, 336);
			this.vNavPaneItem1.TabIndex = 0;
			this.vNavPaneItem1.Text = "vNavPaneItem1";
			this.vNavPaneItem1.TooltipText = "vNavPaneItem1";
			// 
			// MainControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 407);
			this.Controls.Add(this._splitContainer);
			this.Controls.Add(this._toolbar);
			this.Controls.Add(this._status);
			this.Controls.Add(this._topMenu);
			this.MainMenuStrip = this._topMenu;
			this.Name = "MainControl";
			this.Text = "Main";
			this._splitContainer.Panel1.ResumeLayout(false);
			this._splitContainer.ResumeLayout(false);
			this._modules.ResumeLayout(false);
			this.vNavPaneItem1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private VIBlend.WinForms.Controls.vNavPaneItem vNavPaneItem1;
		private VIBlend.WinForms.Controls.vNavPane _modules;
		private System.Windows.Forms.SplitContainer _splitContainer;
		private System.Windows.Forms.ToolStrip _toolbar;
		private System.Windows.Forms.MenuStrip _topMenu;
		private System.Windows.Forms.StatusStrip _status;
	}
}
