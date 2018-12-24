namespace Bayerncraft
{
    partial class LogIn
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbLogin = new MetroFramework.Controls.MetroTextBox();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.btnRegistration = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            // 
            // 
            // 
            this.tbLogin.CustomButton.Image = null;
            this.tbLogin.CustomButton.Location = new System.Drawing.Point(207, 1);
            this.tbLogin.CustomButton.Name = "";
            this.tbLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLogin.CustomButton.TabIndex = 1;
            this.tbLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLogin.CustomButton.UseSelectable = true;
            this.tbLogin.CustomButton.Visible = false;
            this.tbLogin.ForeColor = System.Drawing.Color.DimGray;
            this.tbLogin.Lines = new string[0];
            this.tbLogin.Location = new System.Drawing.Point(336, 148);
            this.tbLogin.MaxLength = 32767;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.PasswordChar = '\0';
            this.tbLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLogin.SelectedText = "";
            this.tbLogin.SelectionLength = 0;
            this.tbLogin.SelectionStart = 0;
            this.tbLogin.ShortcutsEnabled = true;
            this.tbLogin.Size = new System.Drawing.Size(229, 23);
            this.tbLogin.TabIndex = 0;
            this.tbLogin.UseCustomForeColor = true;
            this.tbLogin.UseSelectable = true;
            this.tbLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbPassword
            // 
            // 
            // 
            // 
            this.tbPassword.CustomButton.Image = null;
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(207, 1);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword.CustomButton.TabIndex = 1;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.CustomButton.Visible = false;
            this.tbPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(336, 211);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(229, 23);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseCustomForeColor = true;
            this.tbPassword.UseSelectable = true;
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel2.Location = new System.Drawing.Point(336, 126);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Логин:";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel3.Location = new System.Drawing.Point(336, 189);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Пароль:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(327, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "Авторизация";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.Location = new System.Drawing.Point(476, 332);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseCustomBackColor = true;
            this.btnLogin.UseCustomForeColor = true;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.White;
            this.btnRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistration.Location = new System.Drawing.Point(331, 332);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(121, 23);
            this.btnRegistration.TabIndex = 3;
            this.btnRegistration.Text = "Регистрация";
            this.btnRegistration.UseCustomBackColor = true;
            this.btnRegistration.UseCustomForeColor = true;
            this.btnRegistration.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bayerncraft.Properties.Resources._2015_bmw_x5_m_front_end;
            this.pictureBox1.Location = new System.Drawing.Point(-325, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(649, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(256, -13);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(74, 429);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 408);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.TransparencyKey = System.Drawing.Color.Empty;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tbLogin;
        private MetroFramework.Controls.MetroTextBox tbPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroButton btnRegistration;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}

