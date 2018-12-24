namespace Bayerncraft
{
    partial class AdminLoginForm
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
            this.tbLogin = new MetroFramework.Controls.MetroTextBox();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            // 
            // 
            // 
            this.tbLogin.CustomButton.Image = null;
            this.tbLogin.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.tbLogin.CustomButton.Name = "";
            this.tbLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLogin.CustomButton.TabIndex = 1;
            this.tbLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLogin.CustomButton.UseSelectable = true;
            this.tbLogin.CustomButton.Visible = false;
            this.tbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbLogin.Lines = new string[0];
            this.tbLogin.Location = new System.Drawing.Point(129, 83);
            this.tbLogin.MaxLength = 32767;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.PasswordChar = '\0';
            this.tbLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLogin.SelectedText = "";
            this.tbLogin.SelectionLength = 0;
            this.tbLogin.SelectionStart = 0;
            this.tbLogin.ShortcutsEnabled = true;
            this.tbLogin.Size = new System.Drawing.Size(173, 23);
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
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword.CustomButton.TabIndex = 1;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.CustomButton.Visible = false;
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(129, 127);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(173, 23);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseCustomForeColor = true;
            this.tbPassword.UseSelectable = true;
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel1.Location = new System.Drawing.Point(72, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Логин:";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel2.Location = new System.Drawing.Point(65, 129);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Пароль:";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.Location = new System.Drawing.Point(213, 156);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseCustomBackColor = true;
            this.btnLogin.UseCustomForeColor = true;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 203);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminLoginForm";
            this.Resizable = false;
            this.Text = "Вход в админку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbLogin;
        private MetroFramework.Controls.MetroTextBox tbPassword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnLogin;
    }
}