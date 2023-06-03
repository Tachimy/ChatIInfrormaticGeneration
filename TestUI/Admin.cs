using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace TestUI
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection;
        private async void Admin_Load(object sender, EventArgs e)
        {
            string connectionSource = Database.ConnectionString;
            sqlConnection = new SqlConnection(connectionSource);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlReader = null;

            SqlCommand cmd = new SqlCommand("SELECT login, isAdmin FROM [users]", sqlConnection);
            List<string[]> data = new List<string[]>();

            try
            {
                sqlReader = await cmd.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[2]);

                    data[data.Count - 1][0] = sqlReader[0].ToString();
                    data[data.Count - 1][1] = sqlReader[1].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
            foreach (string[] s in data)
                usersDg.Rows.Add(s);

        }

        private async void addDict_Click(object sender, EventArgs e)
        {
            if (opText.Text.Length > 0 && opValueText.Text.Length > 0 && opText.Text != string.Empty && opValueText.Text != string.Empty)
            {
                SqlCommand command = new SqlCommand("INSERT INTO [opDict] (op,opValue)VALUES(@op, @opValue)", sqlConnection);

                command.Parameters.AddWithValue("op", opText.Text);
                command.Parameters.AddWithValue("opValue", opValueText.Text);

                await command.ExecuteNonQueryAsync();
                MessageBox.Show("Термин добавлен");

            }
            else
            {
                MessageBox.Show("Не хватает какого-то поля!");
            }
        }

        private async void changeRoleBtn_Click(object sender, EventArgs e)
        {
            if (loginUserTb.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE [users] SET isAdmin = 1 WHERE login = @login", sqlConnection);
                cmd.Parameters.AddWithValue("login", loginUserTb.Text);
                await cmd.ExecuteNonQueryAsync();
                MessageBox.Show("Пользователь " + loginUserTb.Text + " назначен администратором" );
            }
            else 
            {
                MessageBox.Show("Поле Логин пустое!");
            }

        }
    }

        
    }

