namespace Bayerncraft
{
    partial class NewPartControl
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
            this.cmbType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbPrice = new MetroFramework.Controls.MetroTextBox();
            this.btnChooseImage = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddPart = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmbMarka = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cmbModel = new MetroFramework.Controls.MetroComboBox();
            this.cmbModification = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ItemHeight = 23;
            this.cmbType.Items.AddRange(new object[] {
            "Блок и головка цилиндров",
            "Включение двигателя",
            "Внутренние отделка и оснащение",
            "Генератор",
            "Двигатель и подвеска",
            "Зажигание двигателя",
            "Инжекционная система запитки",
            "Инструмент",
            "КПП",
            "Кузов и листовые панели",
            "Мост и полуось дифференциала",
            "Навесные части и стекла",
            "Наружная отделка и оснащение",
            "Освещение",
            "Охлаждение",
            "Подвеска и колеса",
            "Рулевое управление",
            "Сиденья",
            "Система климатизации",
            "Смазки",
            "Сцепление",
            "Тормоза",
            "Тяга и щитки",
            "Электрооборудоваие и электропривод"});
            this.cmbType.Location = new System.Drawing.Point(92, 136);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(209, 29);
            this.cmbType.TabIndex = 0;
            this.cmbType.UseSelectable = true;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Gray;
            this.metroLabel1.Location = new System.Drawing.Point(92, 114);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Тип детали:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Gray;
            this.metroLabel2.Location = new System.Drawing.Point(92, 168);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(116, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Название детали:";
            // 
            // tbName
            // 
            // 
            // 
            // 
            this.tbName.CustomButton.Image = null;
            this.tbName.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.tbName.CustomButton.Name = "";
            this.tbName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbName.CustomButton.TabIndex = 1;
            this.tbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbName.CustomButton.UseSelectable = true;
            this.tbName.CustomButton.Visible = false;
            this.tbName.Enabled = false;
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbName.Lines = new string[0];
            this.tbName.Location = new System.Drawing.Point(92, 190);
            this.tbName.MaxLength = 32767;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.ShortcutsEnabled = true;
            this.tbName.Size = new System.Drawing.Size(209, 23);
            this.tbName.TabIndex = 2;
            this.tbName.UseCustomForeColor = true;
            this.tbName.UseSelectable = true;
            this.tbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Gray;
            this.metroLabel3.Location = new System.Drawing.Point(92, 216);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(120, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Описание детали:";
            // 
            // tbDescription
            // 
            // 
            // 
            // 
            this.tbDescription.CustomButton.Image = null;
            this.tbDescription.CustomButton.Location = new System.Drawing.Point(354, 1);
            this.tbDescription.CustomButton.Name = "";
            this.tbDescription.CustomButton.Size = new System.Drawing.Size(69, 69);
            this.tbDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDescription.CustomButton.TabIndex = 1;
            this.tbDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDescription.CustomButton.UseSelectable = true;
            this.tbDescription.CustomButton.Visible = false;
            this.tbDescription.Enabled = false;
            this.tbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbDescription.Lines = new string[0];
            this.tbDescription.Location = new System.Drawing.Point(92, 238);
            this.tbDescription.MaxLength = 32767;
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PasswordChar = '\0';
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDescription.SelectedText = "";
            this.tbDescription.SelectionLength = 0;
            this.tbDescription.SelectionStart = 0;
            this.tbDescription.ShortcutsEnabled = true;
            this.tbDescription.Size = new System.Drawing.Size(424, 71);
            this.tbDescription.TabIndex = 2;
            this.tbDescription.UseCustomForeColor = true;
            this.tbDescription.UseSelectable = true;
            this.tbDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Gray;
            this.metroLabel4.Location = new System.Drawing.Point(92, 312);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Цена:";
            // 
            // tbPrice
            // 
            // 
            // 
            // 
            this.tbPrice.CustomButton.Image = null;
            this.tbPrice.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.tbPrice.CustomButton.Name = "";
            this.tbPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPrice.CustomButton.TabIndex = 1;
            this.tbPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPrice.CustomButton.UseSelectable = true;
            this.tbPrice.CustomButton.Visible = false;
            this.tbPrice.Enabled = false;
            this.tbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPrice.Lines = new string[0];
            this.tbPrice.Location = new System.Drawing.Point(92, 334);
            this.tbPrice.MaxLength = 32767;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPrice.SelectedText = "";
            this.tbPrice.SelectionLength = 0;
            this.tbPrice.SelectionStart = 0;
            this.tbPrice.ShortcutsEnabled = true;
            this.tbPrice.Size = new System.Drawing.Size(209, 23);
            this.tbPrice.TabIndex = 2;
            this.tbPrice.UseCustomForeColor = true;
            this.tbPrice.UseSelectable = true;
            this.tbPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Enabled = false;
            this.btnChooseImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChooseImage.Location = new System.Drawing.Point(376, 190);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(140, 23);
            this.btnChooseImage.TabIndex = 4;
            this.btnChooseImage.Text = "Выбрать изображение";
            this.btnChooseImage.UseCustomBackColor = true;
            this.btnChooseImage.UseCustomForeColor = true;
            this.btnChooseImage.UseSelectable = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(376, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddPart
            // 
            this.btnAddPart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddPart.Enabled = false;
            this.btnAddPart.ForeColor = System.Drawing.Color.White;
            this.btnAddPart.Location = new System.Drawing.Point(376, 334);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(140, 23);
            this.btnAddPart.TabIndex = 5;
            this.btnAddPart.Text = "Добавить";
            this.btnAddPart.UseCustomBackColor = true;
            this.btnAddPart.UseCustomForeColor = true;
            this.btnAddPart.UseSelectable = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.Gray;
            this.metroLabel5.Location = new System.Drawing.Point(92, 3);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(83, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Марка авто:";
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.ItemHeight = 23;
            this.cmbMarka.Location = new System.Drawing.Point(92, 25);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(209, 29);
            this.cmbMarka.TabIndex = 7;
            this.cmbMarka.UseSelectable = true;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.Color.Gray;
            this.metroLabel6.Location = new System.Drawing.Point(307, 3);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(59, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Модель:";
            // 
            // cmbModel
            // 
            this.cmbModel.Enabled = false;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.ItemHeight = 23;
            this.cmbModel.Location = new System.Drawing.Point(307, 25);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(209, 29);
            this.cmbModel.TabIndex = 7;
            this.cmbModel.UseSelectable = true;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // cmbModification
            // 
            this.cmbModification.Enabled = false;
            this.cmbModification.FormattingEnabled = true;
            this.cmbModification.ItemHeight = 23;
            this.cmbModification.Location = new System.Drawing.Point(92, 79);
            this.cmbModification.Name = "cmbModification";
            this.cmbModification.Size = new System.Drawing.Size(209, 29);
            this.cmbModification.TabIndex = 9;
            this.cmbModification.UseSelectable = true;
            this.cmbModification.SelectedIndexChanged += new System.EventHandler(this.cmbModification_SelectedIndexChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.ForeColor = System.Drawing.Color.Gray;
            this.metroLabel7.Location = new System.Drawing.Point(92, 57);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(100, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Модификация:";
            // 
            // NewPartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbModification);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbType);
            this.Name = "NewPartControl";
            this.Size = new System.Drawing.Size(620, 360);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbType;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbDescription;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbPrice;
        private MetroFramework.Controls.MetroButton btnChooseImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnAddPart;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmbMarka;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cmbModel;
        private MetroFramework.Controls.MetroComboBox cmbModification;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}
