using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bayerncraft
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public string   User_Login { get; set; }
        public MainForm(string login)
        {
            InitializeComponent();
            User_Login = login;
            LoadMarkOfAuto();
        }
        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\Bayerncraft.mdb";

        private void LoadMarkOfAuto()
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                flowLayoutPanel1.Controls.Clear();
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT Название, Изображение FROM Марки_Авто", connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MemoryStream memoryStream = new MemoryStream();
                    memoryStream.Write((byte[])reader["Изображение"], 0, ((byte[])reader["Изображение"]).Length);
                    Image image = Image.FromStream(memoryStream);
                    // создаем карточку с авто
                    Carts cart = new Carts(reader["Название"].ToString(), image, this);
                    memoryStream.Dispose();
                    flowLayoutPanel1.Controls.Add(cart);
                }
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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (btnAdmin.Text == "Администратор")
            {
                AdminLoginForm adminLoginForm = new AdminLoginForm(this);
                adminLoginForm.Show();
            }
            else
            {
                LoadMarkOfAuto();
                btnAdmin.Text = "Администратор";
            }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadMarkOfAuto();
        }
    }
}
