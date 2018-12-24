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

namespace Bayerncraft
{
    public partial class NewAdminkaControl : UserControl
    {
        public NewAdminkaControl()
        {
            InitializeComponent();
        }
        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\Bayerncraft.mdb";
        private void tbAddNewAdmin_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();
              
                OleDbCommand command = new OleDbCommand("SELECT * FROM Администраторы WHERE Логин = ? AND Пароль = ?", connection);
                OleDbParameter parameter = new OleDbParameter("Логин", OleDbType.VarChar);
                parameter.Value = tbLogin.Text;
                command.Parameters.Add(parameter);

                OleDbParameter parameter1 = new OleDbParameter("Пароль", OleDbType.VarChar);
                parameter1.Value = tbPassword.Text;
                command.Parameters.Add(parameter1);
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    throw new Exception("Логин занят другим администратором! Введеите другой логин");
                }

                reader.Close();
                RegNewAdmin();
                
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

        void RegNewAdmin()
        {
            OleDbConnection connection = new OleDbConnection(connstring);

            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("INSERT INTO Администраторы(Логин, Пароль) VALUES(?, ?)", connection);

                OleDbParameter parameter = new OleDbParameter("Логин", OleDbType.VarChar);
                parameter.Value = tbLogin.Text;
                command.Parameters.Add(parameter);

                OleDbParameter parameter1 = new OleDbParameter("Пароль", OleDbType.VarChar);
                parameter1.Value = tbPassword.Text;
                command.Parameters.Add(parameter1);

                command.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(this, "Администратор успешно добавлен", "Регистрация нового администратора");
                tbLogin.Clear();
                tbPassword.Clear();
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
