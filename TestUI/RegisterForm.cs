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
using System.Runtime.InteropServices;

namespace TestUI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        SqlConnection sqlConnection;
        string connectionSource = Database.ConnectionString;
        private async void userLoad()
        {
            
            sqlConnection = new SqlConnection(connectionSource);
            await sqlConnection.OpenAsync();

            SqlCommand command = new SqlCommand("SELECT * FROM [users]", sqlConnection);
        }
        private async void regBtn_Click(object sender, EventArgs e)
        {
            string loginUser = regLogTb.Text;
            string passUser = regPassTb.Text;
            if (loginUser != string.Empty && passUser != string.Empty)
            {

                SqlCommand checkLogin = new SqlCommand("SELECT COUNT(login) FROM [users] WHERE  [login] = @login", sqlConnection);
                checkLogin.Parameters.AddWithValue("@login", loginUser);
               
                int checkLoginResult = Convert.ToInt32(checkLogin.ExecuteScalar());

                if (checkLoginResult > 0)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует");
                }
                else 
                {
                    SqlCommand command = new SqlCommand("INSERT INTO [users] (login, password, isAdmin )VALUES(@userLogin, @userPassword, @isAdmin)", sqlConnection);

                    command.Parameters.AddWithValue("userLogin", loginUser);
                    command.Parameters.AddWithValue("userPassword", passUser);
                    command.Parameters.AddWithValue("isAdmin", 0);


                    await command.ExecuteNonQueryAsync();

                userLoad();
                MessageBox.Show("Данные добавлены!");
                }

            }
            else
            {
                MessageBox.Show("Данные введены неполностью!");
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            userLoad();
        }

        private void minLb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitLb_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
