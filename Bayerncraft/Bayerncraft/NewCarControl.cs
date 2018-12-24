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
    public partial class NewCarControl : UserControl
    {
        public NewCarControl()
        {
            InitializeComponent();
            LoadMarks();
        }
        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\Bayerncraft.mdb";

        private void NewCarControl_Load(object sender, EventArgs e)
        {

        }

        void checkMarka()
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT * FROM Марки_Авто WHERE Название = ?", connection);
                OleDbParameter parameter = new OleDbParameter("Название", OleDbType.VarChar);
                parameter.Value = tbName.Text;
                command.Parameters.Add(parameter);
                
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    throw new Exception("Данная марка уже есть в БД!");
                }

                reader.Close();
                AddNewCar();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            checkMarka();
            tbName.Clear();
            pictureBox1.Image = null;
            LoadMarks();
        }
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
                    cmbMarks.Items.Add(reader["Название"].ToString());
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
        void AddNewCar()
        {
            OleDbConnection connection = new OleDbConnection(connstring);

            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("INSERT INTO Марки_Авто(Название, Изображение) VALUES(?, ?)", connection);

                OleDbParameter parameter = new OleDbParameter("Название", OleDbType.VarChar);
                parameter.Value = tbName.Text;
                command.Parameters.Add(parameter);

                MemoryStream memoryStream = new MemoryStream();
                Image image = pictureBox1.Image;
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
                OleDbParameter oleDbParameter1 = new OleDbParameter("Изображение", OleDbType.VarBinary);
                oleDbParameter1.Value = memoryStream.ToArray();
                command.Parameters.Add(oleDbParameter1);

                command.ExecuteNonQuery();
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

        private void btnChoosePicture_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbName_Click(object sender, EventArgs e)
        {

        }

        private void btnChoosePictureModel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Image Files(*.BMP; *.JPG; *.PNG )| *.BMP; *.JPG; *.png | All files(*.*) | *.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog.FileName);
                pictureBox2.Image = img;
            }
        }

        void checkModel()
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT * FROM Модели WHERE Название = ?", connection);
                OleDbParameter parameter = new OleDbParameter("Название", OleDbType.VarChar);
                parameter.Value = tbName.Text;
                command.Parameters.Add(parameter);

                OleDbDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    throw new Exception("Данная марка уже есть в БД!");
                }

                reader.Close();
                AddNewCar();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {

        }
    }
}
