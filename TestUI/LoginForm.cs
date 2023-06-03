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
    public partial class LoginForm : Form
    {
        public LoginForm()
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

            

        }
        

        private async void authBtn_Click(object sender, EventArgs e)
        {
            string connectionSource = Database.ConnectionString;
            sqlConnection = new SqlConnection(connectionSource);
            await sqlConnection.OpenAsync();
            string loginUser = authLogTb.Text;
            string passUser = authPassTb.Text;
            if (loginUser != string.Empty && passUser != string.Empty)
            {

                
                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [users] WHERE  [login] = @user AND [password] = @pass", sqlConnection);
                check_User_Name.Parameters.AddWithValue("@user", loginUser);
                check_User_Name.Parameters.AddWithValue("@pass", passUser);

                SqlCommand check_IsAdmin = new SqlCommand("SELECT isAdmin FROM [users] WHERE  [login] = @user AND [password] = @pass", sqlConnection);
                check_IsAdmin.Parameters.AddWithValue("@user", loginUser);
                check_IsAdmin.Parameters.AddWithValue("@pass", passUser);
                int isAdminResult = Convert.ToInt32(check_IsAdmin.ExecuteScalar());


                int UserExist = (int)check_User_Name.ExecuteScalar();

                if (UserExist > 0)
                {
                    this.Hide();
                    MainMenu mainMenu = new MainMenu();
                    isAdmin.isAdminValue = isAdminResult;
                    userInfo.UserName = loginUser;
                    mainMenu.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
            }
            else
            {
                MessageBox.Show("Данные введены неполностью!");
            }

        }
        private void registerLb_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
        }

        private void minLb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitLb_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }

}
