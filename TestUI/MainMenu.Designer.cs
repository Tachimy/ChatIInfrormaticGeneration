
namespace TestUI
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.dictBtn = new FontAwesome.Sharp.IconButton();
            this.settingsBtn = new FontAwesome.Sharp.IconButton();
            this.chatBtn = new FontAwesome.Sharp.IconButton();
            this.profileBtn = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.collapseButton = new FontAwesome.Sharp.IconButton();
            this.userNameLb = new System.Windows.Forms.Label();
            this.userIcon = new TestUI.RoundedPicBox();
            this.lbChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.panelMenu.Controls.Add(this.dictBtn);
            this.panelMenu.Controls.Add(this.settingsBtn);
            this.panelMenu.Controls.Add(this.chatBtn);
            this.panelMenu.Controls.Add(this.profileBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(269, 750);
            this.panelMenu.TabIndex = 0;
            // 
            // dictBtn
            // 
            this.dictBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.dictBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dictBtn.FlatAppearance.BorderSize = 0;
            this.dictBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dictBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dictBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dictBtn.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.dictBtn.IconColor = System.Drawing.Color.Black;
            this.dictBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dictBtn.IconSize = 40;
            this.dictBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dictBtn.Location = new System.Drawing.Point(0, 274);
            this.dictBtn.Name = "dictBtn";
            this.dictBtn.Size = new System.Drawing.Size(269, 60);
            this.dictBtn.TabIndex = 6;
            this.dictBtn.Text = "Словарь терминов";
            this.dictBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dictBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dictBtn.UseVisualStyleBackColor = false;
            this.dictBtn.Click += new System.EventHandler(this.dictBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.settingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.settingsBtn.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.settingsBtn.IconColor = System.Drawing.Color.Black;
            this.settingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsBtn.IconSize = 40;
            this.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.Location = new System.Drawing.Point(0, 214);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(269, 60);
            this.settingsBtn.TabIndex = 5;
            this.settingsBtn.Text = "Админпанель";
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // chatBtn
            // 
            this.chatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.chatBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatBtn.FlatAppearance.BorderSize = 0;
            this.chatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chatBtn.IconChar = FontAwesome.Sharp.IconChar.FacebookMessenger;
            this.chatBtn.IconColor = System.Drawing.Color.Black;
            this.chatBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.chatBtn.IconSize = 40;
            this.chatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chatBtn.Location = new System.Drawing.Point(0, 154);
            this.chatBtn.Name = "chatBtn";
            this.chatBtn.Size = new System.Drawing.Size(269, 60);
            this.chatBtn.TabIndex = 2;
            this.chatBtn.Text = "Чат";
            this.chatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chatBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chatBtn.UseVisualStyleBackColor = false;
            this.chatBtn.Click += new System.EventHandler(this.chatBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.profileBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.profileBtn.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.profileBtn.IconColor = System.Drawing.Color.Black;
            this.profileBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.profileBtn.IconSize = 40;
            this.profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.Location = new System.Drawing.Point(0, 94);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(269, 60);
            this.profileBtn.TabIndex = 1;
            this.profileBtn.Text = "Личный кабинет";
            this.profileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(269, 94);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.collapseButton);
            this.panel1.Controls.Add(this.userNameLb);
            this.panel1.Controls.Add(this.userIcon);
            this.panel1.Controls.Add(this.lbChildForm);
            this.panel1.Controls.Add(this.iconCurrentChildForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(269, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 75);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.closeButton.IconColor = System.Drawing.Color.Black;
            this.closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeButton.IconSize = 30;
            this.closeButton.Location = new System.Drawing.Point(1304, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(34, 30);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // collapseButton
            // 
            this.collapseButton.FlatAppearance.BorderSize = 0;
            this.collapseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collapseButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.collapseButton.IconColor = System.Drawing.Color.Black;
            this.collapseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.collapseButton.IconSize = 30;
            this.collapseButton.Location = new System.Drawing.Point(1260, 11);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(34, 30);
            this.collapseButton.TabIndex = 3;
            this.collapseButton.UseVisualStyleBackColor = true;
            this.collapseButton.Click += new System.EventHandler(this.collapseButton_Click);
            // 
            // userNameLb
            // 
            this.userNameLb.AutoSize = true;
            this.userNameLb.Font = new System.Drawing.Font("Times New Roman", 14.8F, System.Drawing.FontStyle.Bold);
            this.userNameLb.ForeColor = System.Drawing.Color.Black;
            this.userNameLb.Location = new System.Drawing.Point(974, 37);
            this.userNameLb.Name = "userNameLb";
            this.userNameLb.Size = new System.Drawing.Size(202, 29);
            this.userNameLb.TabIndex = 4;
            this.userNameLb.Text = "Alexandr Nalivko";
            // 
            // userIcon
            // 
            this.userIcon.Image = global::TestUI.Properties.Resources.Без_названия;
            this.userIcon.Location = new System.Drawing.Point(920, 28);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(48, 47);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userIcon.TabIndex = 0;
            this.userIcon.TabStop = false;
            // 
            // lbChildForm
            // 
            this.lbChildForm.AutoSize = true;
            this.lbChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChildForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbChildForm.Location = new System.Drawing.Point(52, 45);
            this.lbChildForm.Name = "lbChildForm";
            this.lbChildForm.Size = new System.Drawing.Size(58, 20);
            this.lbChildForm.TabIndex = 1;
            this.lbChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 39;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 36);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(45, 39);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(269, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1350, 19);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(269, 94);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1350, 656);
            this.panelDesktop.TabIndex = 4;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 750);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton profileBtn;
        private FontAwesome.Sharp.IconButton settingsBtn;
        private FontAwesome.Sharp.IconButton chatBtn;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lbChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private FontAwesome.Sharp.IconButton closeButton;
        private FontAwesome.Sharp.IconButton collapseButton;
        private System.Windows.Forms.Label userNameLb;
        private RoundedPicBox userIcon;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton dictBtn;
    }
}