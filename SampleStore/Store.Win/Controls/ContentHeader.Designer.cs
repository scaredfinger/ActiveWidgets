namespace Store.Controls
{
    partial class ContentHeader
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._content = new CG.Controls.Misc.RoundedPanel(this.components);
            this._tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this._icon = new System.Windows.Forms.PictureBox();
            this._title = new CG.Controls.Grid.Text.ExLabel();
            this._content.SuspendLayout();
            this._tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._icon)).BeginInit();
            this.SuspendLayout();
            // 
            // _content
            // 
            this._content.BackColor = System.Drawing.Color.Transparent;
            this._content.BorderColor = System.Drawing.Color.SteelBlue;
            this._content.BorderWidth = 1;
            this._content.ColorPreset = CG.Controls.Common.ColorPresetType.Blue;
            this._content.Controls.Add(this._tableLayout);
            this._content.CornerRadiusLeftBottom = 20;
            this._content.CornerRadiusLeftTop = 20;
            this._content.CornerRadiusRightBottom = 20;
            this._content.CornerRadiusRightTop = 20;
            this._content.Dock = System.Windows.Forms.DockStyle.Fill;
            this._content.GradientAngle = 90F;
            this._content.GradientColorFrom = System.Drawing.Color.AliceBlue;
            this._content.GradientColorTo = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this._content.GroupText = "";
            this._content.GroupTextOffSetX = 5;
            this._content.GroupTextOffSetY = 0;
            this._content.Location = new System.Drawing.Point(0, 0);
            this._content.Name = "_content";
            this._content.RepaintOnResize = false;
            this._content.ShowGroupTextBorder = false;
            this._content.Size = new System.Drawing.Size(784, 117);
            this._content.TabIndex = 0;
            this._content.TextBackColor = System.Drawing.SystemColors.Control;
            this._content.TextColor = System.Drawing.Color.Black;
            // 
            // _tableLayout
            // 
            this._tableLayout.ColumnCount = 2;
            this._tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this._tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayout.Controls.Add(this._icon, 0, 0);
            this._tableLayout.Controls.Add(this._title, 1, 0);
            this._tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayout.Location = new System.Drawing.Point(0, 0);
            this._tableLayout.Name = "_tableLayout";
            this._tableLayout.RowCount = 1;
            this._tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayout.Size = new System.Drawing.Size(784, 117);
            this._tableLayout.TabIndex = 0;
            // 
            // _icon
            // 
            this._icon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._icon.Location = new System.Drawing.Point(8, 34);
            this._icon.Name = "_icon";
            this._icon.Size = new System.Drawing.Size(48, 48);
            this._icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._icon.TabIndex = 0;
            this._icon.TabStop = false;
            // 
            // _title
            // 
            this._title.AutoSize = true;
            this._title.Dock = System.Windows.Forms.DockStyle.Fill;
            this._title.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._title.Location = new System.Drawing.Point(67, 0);
            this._title.Name = "_title";
            this._title.RenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this._title.Size = new System.Drawing.Size(714, 117);
            this._title.TabIndex = 1;
            this._title.Text = "Welcome Jurassic Park";
            this._title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContentHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._content);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ContentHeader";
            this.Size = new System.Drawing.Size(784, 117);
            this._content.ResumeLayout(false);
            this._tableLayout.ResumeLayout(false);
            this._tableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CG.Controls.Misc.RoundedPanel _content;
        private System.Windows.Forms.TableLayoutPanel _tableLayout;
        private System.Windows.Forms.PictureBox _icon;
        private CG.Controls.Grid.Text.ExLabel _title;
    }
}
