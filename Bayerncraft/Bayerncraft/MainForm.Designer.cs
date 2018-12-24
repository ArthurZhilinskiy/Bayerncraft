namespace Bayerncraft
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CPanel = new MetroFramework.Controls.MetroPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnAdmin = new MetroFramework.Controls.MetroTile();
            this.CPanel.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CPanel
            // 
            this.CPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPanel.Controls.Add(this.flowLayoutPanel1);
            this.CPanel.HorizontalScrollbarBarColor = true;
            this.CPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.CPanel.HorizontalScrollbarSize = 10;
            this.CPanel.Location = new System.Drawing.Point(23, 119);
            this.CPanel.Name = "CPanel";
            this.CPanel.Size = new System.Drawing.Size(788, 390);
            this.CPanel.TabIndex = 0;
            this.CPanel.VerticalScrollbarBarColor = true;
            this.CPanel.VerticalScrollbarHighlightOnWheel = false;
            this.CPanel.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(788, 390);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.btnAdmin);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(788, 53);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnAdmin
            // 
            this.btnAdmin.ActiveControl = null;
            this.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdmin.Location = new System.Drawing.Point(642, 3);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.PaintTileCount = false;
            this.btnAdmin.Size = new System.Drawing.Size(142, 47);
            this.btnAdmin.Style = MetroFramework.MetroColorStyle.White;
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Администратор";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAdmin.TileImage = global::Bayerncraft.Properties.Resources.icons8_бизнесмен_filled_40;
            this.btnAdmin.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmin.UseCustomForeColor = true;
            this.btnAdmin.UseSelectable = true;
            this.btnAdmin.UseTileImage = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 532);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.CPanel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Bayerncraft: магазин автозапчастей";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.CPanel.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel CPanel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public MetroFramework.Controls.MetroTile btnAdmin;
    }
}