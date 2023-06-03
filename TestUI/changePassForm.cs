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
using System.Drawing.Text;

namespace TestUI
{
    public partial class changePassForm : Form
    {
        public changePassForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection;
        string connectionSource = Database.ConnectionString;
        private  void changePassForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionSource);
        }

        private async void changePassBtn_Click(object sender, EventArgs e)
        {
            string userPassword = passTb.Text;


            await sqlConnection.OpenAsync();

            SqlCommand changeEmail = new SqlCommand("UPDATE users SET password = @pass WHERE  [login] = @login", sqlConnection);
            changeEmail.Parameters.AddWithValue("@pass", userPassword);
            changeEmail.Parameters.AddWithValue("@login", userInfo.UserName);
            await changeEmail.ExecuteNonQueryAsync();

            MessageBox.Show("Пароль обновлен");
        }
    }
}
