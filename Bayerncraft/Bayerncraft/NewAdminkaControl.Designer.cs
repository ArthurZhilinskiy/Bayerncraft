namespace Bayerncraft
{
    partial class NewAdminkaControl
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbAddNewAdmin = new MetroFramework.Controls.MetroButton();
            this.tbLogin = new MetroFramework.Controls.MetroTextBox();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel1.Location = new System.Drawing.Point(168, 112);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Логин:";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // tbAddNewAdmin
            // 
            this.tbAddNewAdmin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tbAddNewAdmin.ForeColor = System.Drawing.Color.White;
            this.tbAddNewAdmin.Location = new System.Drawing.Point(318, 199);
            this.tbAddNewAdmin.Name = "tbAddNewAdmin";
            this.tbAddNewAdmin.Size = new System.Drawing.Size(98, 23);
            this.tbAddNewAdmin.TabIndex = 2;
            this.tbAddNewAdmin.Text = "Добавить";
            this.tbAddNewAdmin.UseCustomBackColor = true;
            this.tbAddNewAdmin.UseCustomForeColor = true;
            this.tbAddNewAdmin.UseSelectable = true;
            this.tbAddNewAdmin.Click += new System.EventHandler(this.tbAddNewAdmin_Click);
            // 
            // tbLogin
            // 
            // 
            // 
            // 
            this.tbLogin.CustomButton.Image = null;
            this.tbLogin.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.tbLogin.CustomButton.Name = "";
            this.tbLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLogin.CustomButton.TabIndex = 1;
            this.tbLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLogin.CustomButton.UseSelectable = true;
            this.tbLogin.CustomButton.Visible = false;
            this.tbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbLogin.Lines = new string[0];
            this.tbLogin.Location = new System.Drawing.Point(231, 109);
            this.tbLogin.MaxLength = 32767;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.PasswordChar = '\0';
            this.tbLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLogin.SelectedText = "";
            this.tbLogin.SelectionLength = 0;
            this.tbLogin.SelectionStart = 0;
            this.tbLogin.ShortcutsEnabled = true;
            this.tbLogin.Size = new System.Drawing.Size(185, 23);
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
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword.CustomButton.TabIndex = 1;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.CustomButton.Visible = false;
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(231, 154);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(185, 23);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseCustomForeColor = true;
            this.tbPassword.UseSelectable = true;
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel2.Location = new System.Drawing.Point(161, 156);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Пароль:";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // NewAdminkaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbAddNewAdmin);
            this.Controls.Add(this.tbLogin);
            this.Name = "NewAdminkaControl";
            this.Size = new System.Drawing.Size(620, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton tbAddNewAdmin;
        private MetroFramework.Controls.MetroTextBox tbLogin;
        private MetroFramework.Controls.MetroTextBox tbPassword;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}
