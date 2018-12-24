namespace Bayerncraft
{
    partial class AdminControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.NewDetail = new MetroFramework.Controls.MetroTile();
            this.NewMark = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(143, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(627, 370);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroTile1.Location = new System.Drawing.Point(17, 247);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(120, 120);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "Новая админка";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = global::Bayerncraft.Properties.Resources.icons8_модератор_filled_80;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // NewDetail
            // 
            this.NewDetail.ActiveControl = null;
            this.NewDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewDetail.Location = new System.Drawing.Point(17, 124);
            this.NewDetail.Name = "NewDetail";
            this.NewDetail.Size = new System.Drawing.Size(120, 120);
            this.NewDetail.Style = MetroFramework.MetroColorStyle.White;
            this.NewDetail.TabIndex = 1;
            this.NewDetail.Text = "Добавить деталь";
            this.NewDetail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewDetail.TileImage = global::Bayerncraft.Properties.Resources.icons8_инженерия_filled_80;
            this.NewDetail.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NewDetail.UseCustomForeColor = true;
            this.NewDetail.UseSelectable = true;
            this.NewDetail.UseTileImage = true;
            this.NewDetail.Click += new System.EventHandler(this.NewDetail_Click);
            // 
            // NewMark
            // 
            this.NewMark.ActiveControl = null;
            this.NewMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewMark.Location = new System.Drawing.Point(17, 3);
            this.NewMark.Name = "NewMark";
            this.NewMark.Size = new System.Drawing.Size(120, 120);
            this.NewMark.Style = MetroFramework.MetroColorStyle.White;
            this.NewMark.TabIndex = 1;
            this.NewMark.Text = "Добавить марку";
            this.NewMark.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewMark.TileImage = global::Bayerncraft.Properties.Resources.icons8_автомобиль_filled_80;
            this.NewMark.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NewMark.UseCustomForeColor = true;
            this.NewMark.UseSelectable = true;
            this.NewMark.UseTileImage = true;
            this.NewMark.Click += new System.EventHandler(this.NewMark_Click);
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.NewDetail);
            this.Controls.Add(this.NewMark);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(770, 370);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile NewMark;
        private MetroFramework.Controls.MetroTile NewDetail;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}
