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



namespace TestUI
{
    public partial class changeEmailForm : Form
    {
        public changeEmailForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection;
        string connectionSource = Database.ConnectionString;
        private void changeEmailForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionSource);
        }
        private async void changeEmailBtn_Click(object sender, EventArgs e)
        {
            userInfo.Email = emailTb.Text;

            await sqlConnection.OpenAsync();

            SqlCommand changeEmail = new SqlCommand("UPDATE users SET email = @email WHERE  [login] = @login", sqlConnection);
            changeEmail.Parameters.AddWithValue("@email", userInfo.Email);
            changeEmail.Parameters.AddWithValue("@login", userInfo.UserName);
            await changeEmail.ExecuteNonQueryAsync();

            MessageBox.Show("E-Mail адресс обновлен!");

        }

        
    }
}
