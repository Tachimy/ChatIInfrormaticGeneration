using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace TestUI
{
    public partial class MainMenu : Form
    {
        //Объявление хранения активной кнопки и границы к кнопке 
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        
        private Form currentChildForm;


        public MainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 50);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Height = 750;
            this.Width = 1225;
            panel1.Width= this.Width;
            

            

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

           
        }
        //Методы для работы 

            private void ActiveButton(object senderBtn)
            {
                if (senderBtn != null)
                {
                    DisableButton();
                    currentBtn = (IconButton)senderBtn;
                    currentBtn.BackColor = Color.Gray;
                    currentBtn.ForeColor = Color.Black;
                    currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                    currentBtn.IconColor = Color.Black;
                    currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                    leftBorderBtn.BackColor = Color.Black;
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();

                    iconCurrentChildForm.IconChar = currentBtn.IconChar;
                    iconCurrentChildForm.IconColor = Color.Black;

                }
            }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(179,229,252);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();

            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbChildForm.Text = childForm.Text;


        }
        private void profileBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new Profile());
        }

        private void chatBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new Chat());
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new Admin());
        }
        private void dictBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new DictionaryForm());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Black;
            lbChildForm.Text = "Home";
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0X112, 0xf012, 0);
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {
            Reset();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void collapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (isAdmin.isAdminValue == 0)
            {
                settingsBtn.Visible = false;
            }
            else
            {
                settingsBtn.Visible = true;
            }

            userNameLb.Text = userInfo.UserName;
        }

   
    }
}
