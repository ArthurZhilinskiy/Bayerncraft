namespace Bayerncraft
{
    partial class NewCarControl
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
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChoosePicture = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAddNewCar = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbMarks = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbName_model = new MetroFramework.Controls.MetroTextBox();
            this.btnChoosePictureModel = new MetroFramework.Controls.MetroButton();
            this.btnAddModel = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            // 
            // 
            // 
            this.tbName.CustomButton.Image = null;
            this.tbName.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.tbName.CustomButton.Name = "";
            this.tbName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbName.CustomButton.TabIndex = 1;
            this.tbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbName.CustomButton.UseSelectable = true;
            this.tbName.CustomButton.Visible = false;
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbName.Lines = new string[0];
            this.tbName.Location = new System.Drawing.Point(152, 41);
            this.tbName.MaxLength = 32767;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.ShortcutsEnabled = true;
            this.tbName.Size = new System.Drawing.Size(185, 23);
            this.tbName.TabIndex = 1;
            this.tbName.UseCustomForeColor = true;
            this.tbName.UseSelectable = true;
            this.tbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbName.Click += new System.EventHandler(this.tbName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChoosePicture.Location = new System.Drawing.Point(6, 136);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.Size = new System.Drawing.Size(140, 23);
            this.btnChoosePicture.TabIndex = 2;
            this.btnChoosePicture.Text = "Выбрать изображение";
            this.btnChoosePicture.UseCustomBackColor = true;
            this.btnChoosePicture.UseCustomForeColor = true;
            this.btnChoosePicture.UseSelectable = true;
            this.btnChoosePicture.Click += new System.EventHandler(this.btnChoosePicture_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel1.Location = new System.Drawing.Point(152, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Название:";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddNewCar.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCar.Location = new System.Drawing.Point(197, 136);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(140, 23);
            this.btnAddNewCar.TabIndex = 2;
            this.btnAddNewCar.Text = "Добавить";
            this.btnAddNewCar.UseCustomBackColor = true;
            this.btnAddNewCar.UseCustomForeColor = true;
            this.btnAddNewCar.UseSelectable = true;
            this.btnAddNewCar.Click += new System.EventHandler(this.btnAddNewCar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.btnAddNewCar);
            this.groupBox1.Controls.Add(this.btnChoosePicture);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 164);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Марка авто";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbMarks);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.tbName_model);
            this.groupBox2.Controls.Add(this.btnChoosePictureModel);
            this.groupBox2.Controls.Add(this.btnAddModel);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(0, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 195);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Модель";
            // 
            // cmbMarks
            // 
            this.cmbMarks.FormattingEnabled = true;
            this.cmbMarks.ItemHeight = 23;
            this.cmbMarks.Location = new System.Drawing.Point(152, 41);
            this.cmbMarks.Name = "cmbMarks";
            this.cmbMarks.Size = new System.Drawing.Size(185, 29);
            this.cmbMarks.TabIndex = 4;
            this.cmbMarks.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel3.Location = new System.Drawing.Point(152, 19);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Марка авто:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel2.Location = new System.Drawing.Point(152, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Название:";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // tbName_model
            // 
            // 
            // 
            // 
            this.tbName_model.CustomButton.Image = null;
            this.tbName_model.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.tbName_model.CustomButton.Name = "";
            this.tbName_model.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbName_model.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbName_model.CustomButton.TabIndex = 1;
            this.tbName_model.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbName_model.CustomButton.UseSelectable = true;
            this.tbName_model.CustomButton.Visible = false;
            this.tbName_model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbName_model.Lines = new string[0];
            this.tbName_model.Location = new System.Drawing.Point(152, 95);
            this.tbName_model.MaxLength = 32767;
            this.tbName_model.Name = "tbName_model";
            this.tbName_model.PasswordChar = '\0';
            this.tbName_model.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbName_model.SelectedText = "";
            this.tbName_model.SelectionLength = 0;
            this.tbName_model.SelectionStart = 0;
            this.tbName_model.ShortcutsEnabled = true;
            this.tbName_model.Size = new System.Drawing.Size(185, 23);
            this.tbName_model.TabIndex = 1;
            this.tbName_model.UseCustomForeColor = true;
            this.tbName_model.UseSelectable = true;
            this.tbName_model.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbName_model.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbName_model.Click += new System.EventHandler(this.tbName_Click);
            // 
            // btnChoosePictureModel
            // 
            this.btnChoosePictureModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChoosePictureModel.Location = new System.Drawing.Point(6, 136);
            this.btnChoosePictureModel.Name = "btnChoosePictureModel";
            this.btnChoosePictureModel.Size = new System.Drawing.Size(140, 23);
            this.btnChoosePictureModel.TabIndex = 2;
            this.btnChoosePictureModel.Text = "Выбрать изображение";
            this.btnChoosePictureModel.UseCustomBackColor = true;
            this.btnChoosePictureModel.UseCustomForeColor = true;
            this.btnChoosePictureModel.UseSelectable = true;
            this.btnChoosePictureModel.Click += new System.EventHandler(this.btnChoosePictureModel_Click);
            // 
            // btnAddModel
            // 
            this.btnAddModel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddModel.ForeColor = System.Drawing.Color.White;
            this.btnAddModel.Location = new System.Drawing.Point(197, 136);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(140, 23);
            this.btnAddModel.TabIndex = 2;
            this.btnAddModel.Text = "Добавить";
            this.btnAddModel.UseCustomBackColor = true;
            this.btnAddModel.UseCustomForeColor = true;
            this.btnAddModel.UseSelectable = true;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(6, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NewCarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewCarControl";
            this.Size = new System.Drawing.Size(620, 360);
            this.Load += new System.EventHandler(this.NewCarControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox tbName;
        private MetroFramework.Controls.MetroButton btnChoosePicture;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAddNewCar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox cmbMarks;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbName_model;
        private MetroFramework.Controls.MetroButton btnChoosePictureModel;
        private MetroFramework.Controls.MetroButton btnAddModel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
