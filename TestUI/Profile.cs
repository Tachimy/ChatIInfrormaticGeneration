using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;

namespace TestUI
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection;
        string connectionSource = Database.ConnectionString;
        string email;

        private async void Profile_Load(object sender, EventArgs e)
        {
            if (isAdmin.isAdminValue == 0)
            {
                statusUserLb.Text = "Пользователь";
            }
            else
            {
                statusUserLb.Text = "Администратор";
            }

            userNameLb.Text = userInfo.UserName;

            changeEmailBtn.Location = new System.Drawing.Point((int)(eMailLb.Right * 1.5), 105);

            sqlConnection = new SqlConnection(connectionSource);
            await sqlConnection.OpenAsync();

            SqlCommand userEmail = new SqlCommand("SELECT email FROM [users] WHERE  [login] = @login", sqlConnection);
            userEmail.Parameters.AddWithValue("@login", userInfo.UserName);
            email = Convert.ToString(userEmail.ExecuteScalar());

            if (email == String.Empty)
            {
                eMailLb.Text = "-none-";
            }

            else
            {
                eMailLb.Text = email;
            }



        }

        private void changeEmailBtn_Click(object sender, EventArgs e)
        {
            changeEmailForm changeEmailForm = new changeEmailForm();
            changeEmailForm.Show();
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            changePassForm changePassForm = new changePassForm();
            changePassForm.Show();
        }
    }
}
