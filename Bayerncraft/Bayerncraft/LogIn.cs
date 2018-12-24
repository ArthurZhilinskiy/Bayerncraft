using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bayerncraft
{
    public partial class LogIn : MetroFramework.Forms.MetroForm
    {
        public LogIn()
        {
            InitializeComponent();
        }

        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+@"\Bayerncraft.mdb";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();
                
                OleDbCommand command = new OleDbCommand("Select * From Пользователи WHERE Логин = ? AND Пароль = ?", connection);
                OleDbParameter parameter = new OleDbParameter("Логин", OleDbType.VarChar);
                parameter.Value = tbLogin.Text;
                command.Parameters.Add(parameter);

                OleDbParameter parameter1 = new OleDbParameter("Пароль", OleDbType.VarChar);
                parameter1.Value = tbPassword.Text;
                command.Parameters.Add(parameter1);

                OleDbDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    tbLogin.WithError = true;
                    tbPassword.WithError = true;
                }
                while (reader.Read())
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
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
    }
}
