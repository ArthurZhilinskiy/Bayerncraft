using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Bayerncraft
{
    public partial class NewPartControl : UserControl
    {
        public NewPartControl()
        {
            InitializeComponent();
            LoadMarks();
        }
        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\Bayerncraft.mdb";

        void LoadMarks()
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT Название FROM Марки_Авто", connection);

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbMarka.Items.Add(reader["Название"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
       
        string ID_Марки = "1";
        string ID_Модели = "1";
        string ID_Модификации = "1";
        void GetID_Марки()
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT ID_Марки FROM Марки_Авто WHERE Название = ?", connection);
                OleDbParameter parameter = new OleDbParameter("Название", OleDbType.VarChar);
                parameter.Value = cmbMarka.Text;
                command.Parameters.Add(parameter);

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ID_Марки = reader["ID_Марки"].ToString();
                    cmbModel.Enabled = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        void GetID_Модели()
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT ID_Модели FROM Модели_Марки WHERE ID_Марки = ?", connection);
                OleDbParameter parameter = new OleDbParameter("ID_Марки", OleDbType.Integer);
                parameter.Value = Convert.ToInt32(ID_Марки);
                command.Parameters.Add(parameter);

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ID_Модели = reader["ID_Марки"].ToString();
                    cmbModification.Enabled = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetID_Марки();
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetID_Модели();
        }

        private void cmbModification_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetID_Модификации();
        }

        void GetID_Модификации()
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT ID_Модификации FROM Модификации_Модели WHERE ID_Модели = ?", connection);
                OleDbParameter parameter = new OleDbParameter("ID_Модели", OleDbType.Integer);
                parameter.Value = Convert.ToInt32(ID_Модели);
                command.Parameters.Add(parameter);

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ID_Модели = reader["ID_Модификации"].ToString();
                    cmbModification.Enabled = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        string TableName;

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbName.Enabled = true;
            tbDescription.Enabled = true;
            tbPrice.Enabled = true;
            btnChooseImage.Enabled = true;
            btnAddPart.Enabled = true;

            //*********Получаем название таблицы с типом детали****************//
            switch (cmbType.SelectedIndex)
            {
                case 0:
                    TableName = "Блок_и_головка_цилиндров";
                    break;
                case 1:
                    TableName = "Включение_двигателя";
                    break;
                case 2:
                    TableName = "Внутренние_отделка_и_оснащение";
                    break;
                case 3:
                    TableName = "Генератор";
                    break;
                case 4:
                    TableName = "Двигатель_и_подвеска";
                    break;
                case 5:
                    TableName = "Зажигание_двигателя";
                    break;
                case 6:
                    TableName = "Инжекционная_система_запитки";
                    break;
                case 7:
                    TableName = "Инструмент";
                    break;
                case 8:
                    TableName = "КПП";
                    break;
                case 9:
                    TableName = "Кузов_и_листовые_панели";
                    break;
                case 10:
                    TableName = "Мост_и_полуось_дифференциала";
                    break;
                case 11:
                    TableName = "Навесные_части_и_стекла";
                    break;
                case 12:
                    TableName = "Наружная_отделка_и_оснащение";
                    break;
                case 13:
                    TableName = "Освещение";
                    break;
                case 14:
                    TableName = "Охлаждение";
                    break;
                case 15:
                    TableName = "Подвеска_и_колеса";
                    break;
                case 16:
                    TableName = "Рулевое_управление";
                    break;
                case 17:
                    TableName = "Сиденья";
                    break;
                case 18:
                    TableName = "Система_климатизации";
                    break;
                case 19:
                    TableName = "Смазки";
                    break;
                case 20:
                    TableName = "Сцепление";
                    break;
                case 21:
                    TableName = "Тормоза";
                    break;
                case 22:
                    TableName = "Тяга_и_щитки";
                    break;
                case 23:
                    TableName = "Электрооборудование_и_электропривод";
                    break;
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Image Files(*.BMP; *.JPG; *.PNG )| *.BMP; *.JPG; *.png | All files(*.*) | *.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = img;
            }
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("INSERT INTO "+TableName+"(Название, Описание, Цена, Изображение, ID_Модификации) VALUES(?, ?, ?, ?, ?)", connection);
                OleDbParameter parameter = new OleDbParameter("Название", OleDbType.VarChar);
                parameter.Value = tbName.Text;
                command.Parameters.Add(parameter);

                OleDbParameter parameter1 = new OleDbParameter("Описание", OleDbType.VarChar);
                parameter1.Value = tbDescription.Text;
                command.Parameters.Add(parameter1);

                OleDbParameter parameter2 = new OleDbParameter("Цена", OleDbType.VarChar);
                parameter2.Value = tbPrice.Text;
                command.Parameters.Add(parameter2);

                MemoryStream memoryStream = new MemoryStream();
                Image image = pictureBox1.Image;
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
                OleDbParameter parameter3 = new OleDbParameter("Изображение", OleDbType.Binary);
                parameter3.Value = memoryStream.ToArray();
                command.Parameters.Add(parameter3);

                OleDbParameter parameter4 = new OleDbParameter("ID_Модификации", OleDbType.VarChar);
                parameter4.Value = ID_Модификации;
                command.Parameters.Add(parameter4);

                command.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
