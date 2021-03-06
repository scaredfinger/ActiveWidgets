﻿
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
			this.components = new System.ComponentModel.Container();
			CG.Controls.NavigationBar.Office2007NavigationBarRenderer office2007NavigationBarRenderer1 = new CG.Controls.NavigationBar.Office2007NavigationBarRenderer();
			this._status = new System.Windows.Forms.StatusStrip();
			this._fixedText = new System.Windows.Forms.ToolStripStatusLabel();
			this._flashNotifications = new System.Windows.Forms.ToolStripStatusLabel();
			this._topMenu = new System.Windows.Forms.MenuStrip();
			this._toolbar = new System.Windows.Forms.ToolStrip();
			this._rightLayout = new System.Windows.Forms.TableLayoutPanel();
			this._header = new Store.Controls.ContentHeader();
			this._modulesBar = new CG.Controls.NavigationBar.ExNavigationBar();
			this._mainLayout = new System.Windows.Forms.FlowLayoutPanel();
			this._status.SuspendLayout();
			this._rightLayout.SuspendLayout();
			this._mainLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// _status
			// 
			this._status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
			this._status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this._fixedText,
									this._flashNotifications});
			this._status.Location = new System.Drawing.Point(0, 385);
			this._status.Name = "_status";
			this._status.Size = new System.Drawing.Size(569, 22);
			this._status.TabIndex = 0;
			this._status.Text = "_status";
			// 
			// _fixedText
			// 
			this._fixedText.Name = "_fixedText";
			this._fixedText.Size = new System.Drawing.Size(66, 17);
			this._fixedText.Text = "[Fixed Text]";
			// 
			// _flashNotifications
			// 
			this._flashNotifications.Name = "_flashNotifications";
			this._flashNotifications.Size = new System.Drawing.Size(102, 17);
			this._flashNotifications.Text = "[Flash Notifications]";
			this._flashNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _topMenu
			// 
			this._topMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
			this._topMenu.Location = new System.Drawing.Point(0, 0);
			this._topMenu.Name = "_topMenu";
			this._topMenu.Size = new System.Drawing.Size(569, 24);
			this._topMenu.TabIndex = 1;
			// 
			// _toolbar
			// 
			this._toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
			this._toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this._toolbar.ImageScalingSize = new System.Drawing.Size(24, 24);
			this._toolbar.Location = new System.Drawing.Point(0, 24);
			this._toolbar.Name = "_toolbar";
			this._toolbar.Size = new System.Drawing.Size(569, 25);
			this._toolbar.TabIndex = 3;
			// 
			// _rightLayout
			// 
			this._rightLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
			this._rightLayout.ColumnCount = 1;
			this._rightLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._rightLayout.Controls.Add(this._header, 0, 0);
			this._rightLayout.Location = new System.Drawing.Point(231, 0);
			this._rightLayout.Margin = new System.Windows.Forms.Padding(0);
			this._rightLayout.Name = "_rightLayout";
			this._rightLayout.RowCount = 2;
			this._rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this._rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._rightLayout.Size = new System.Drawing.Size(336, 330);
			this._rightLayout.TabIndex = 9;
			// 
			// _header
			// 
			this._header.Dock = System.Windows.Forms.DockStyle.Fill;
			this._header.Location = new System.Drawing.Point(0, 0);
			this._header.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
			this._header.Name = "_header";
			this._header.Size = new System.Drawing.Size(331, 100);
			this._header.TabIndex = 0;
			// 
			// _modulesBar
			// 
			this._modulesBar.Expanded = true;
			this._modulesBar.Location = new System.Drawing.Point(3, 3);
			this._modulesBar.Name = "_modulesBar";
			this._modulesBar.PanelsVisible = 0;
			office2007NavigationBarRenderer1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
			office2007NavigationBarRenderer1.PanelBackColor = System.Drawing.Color.White;
			this._modulesBar.Renderer = office2007NavigationBarRenderer1;
			this._modulesBar.SelectedPanel = null;
			this._modulesBar.ShowExpandsionIndicator = true;
			this._modulesBar.Size = new System.Drawing.Size(225, 330);
			this._modulesBar.SplitterLocked = false;
			this._modulesBar.TabIndex = 7;
			this._modulesBar.Text = "Modules";
			this._modulesBar.ExpansionStateChanged += new System.EventHandler(this.ModulesBarExpandedChanged);
			// 
			// _mainLayout
			// 
			this._mainLayout.Controls.Add(this._modulesBar);
			this._mainLayout.Controls.Add(this._rightLayout);
			this._mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this._mainLayout.Location = new System.Drawing.Point(0, 49);
			this._mainLayout.Margin = new System.Windows.Forms.Padding(0);
			this._mainLayout.Name = "_mainLayout";
			this._mainLayout.Size = new System.Drawing.Size(569, 336);
			this._mainLayout.TabIndex = 4;
			this._mainLayout.WrapContents = false;
			this._mainLayout.SizeChanged += new System.EventHandler(this.MainLayoutResized);
			// 
			// MainControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 407);
			this.Controls.Add(this._mainLayout);
			this.Controls.Add(this._toolbar);
			this.Controls.Add(this._status);
			this.Controls.Add(this._topMenu);
			this.MainMenuStrip = this._topMenu;
			this.Name = "MainControl";
			this.Text = "Main";
			this._status.ResumeLayout(false);
			this._status.PerformLayout();
			this._rightLayout.ResumeLayout(false);
			this._mainLayout.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TableLayoutPanel _rightLayout;
		private System.Windows.Forms.FlowLayoutPanel _mainLayout;
		private CG.Controls.NavigationBar.ExNavigationBar _modulesBar;
		private System.Windows.Forms.ToolStrip _toolbar;
		private System.Windows.Forms.MenuStrip _topMenu;
		private System.Windows.Forms.StatusStrip _status;
        private Controls.ContentHeader _header;
        private System.Windows.Forms.ToolStripStatusLabel _fixedText;
        private System.Windows.Forms.ToolStripStatusLabel _flashNotifications;
	}
}
