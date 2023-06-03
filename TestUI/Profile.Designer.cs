
namespace TestUI
{
    partial class Profile
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
            this.userName = new System.Windows.Forms.Label();
            this.userNameLb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eMailLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusUserLb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.changePassBtn = new FontAwesome.Sharp.IconButton();
            this.changeEmailBtn = new FontAwesome.Sharp.IconButton();
            this.userIcon = new TestUI.RoundedPicBox();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Times New Roman", 17.8F, System.Drawing.FontStyle.Bold);
            this.userName.Location = new System.Drawing.Point(373, 74);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(84, 35);
            this.userName.TabIndex = 2;
            this.userName.Text = "Имя:";
            // 
            // userNameLb
            // 
            this.userNameLb.AutoSize = true;
            this.userNameLb.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLb.Location = new System.Drawing.Point(549, 75);
            this.userNameLb.Name = "userNameLb";
            this.userNameLb.Size = new System.Drawing.Size(230, 34);
            this.userNameLb.TabIndex = 6;
            this.userNameLb.Text = "Alexandr Naliwko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 34);
            this.label4.TabIndex = 9;
            // 
            // eMailLb
            // 
            this.eMailLb.AutoSize = true;
            this.eMailLb.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eMailLb.Location = new System.Drawing.Point(549, 130);
            this.eMailLb.Name = "eMailLb";
            this.eMailLb.Size = new System.Drawing.Size(93, 34);
            this.eMailLb.TabIndex = 11;
            this.eMailLb.Text = "-none-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 17.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(373, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "E-mail:";
            // 
            // statusUserLb
            // 
            this.statusUserLb.AutoSize = true;
            this.statusUserLb.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusUserLb.Location = new System.Drawing.Point(549, 186);
            this.statusUserLb.Name = "statusUserLb";
            this.statusUserLb.Size = new System.Drawing.Size(93, 34);
            this.statusUserLb.TabIndex = 13;
            this.statusUserLb.Text = "-none-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 17.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(373, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 35);
            this.label5.TabIndex = 12;
            this.label5.Text = "Статус: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(373, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "Сменить пароль:";
            // 
            // changePassBtn
            // 
            this.changePassBtn.FlatAppearance.BorderSize = 0;
            this.changePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.changePassBtn.IconColor = System.Drawing.Color.Black;
            this.changePassBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.changePassBtn.Location = new System.Drawing.Point(717, 297);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(62, 56);
            this.changePassBtn.TabIndex = 16;
            this.changePassBtn.UseVisualStyleBackColor = true;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // changeEmailBtn
            // 
            this.changeEmailBtn.FlatAppearance.BorderSize = 0;
            this.changeEmailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeEmailBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.changeEmailBtn.IconColor = System.Drawing.Color.Black;
            this.changeEmailBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.changeEmailBtn.Location = new System.Drawing.Point(717, 121);
            this.changeEmailBtn.Name = "changeEmailBtn";
            this.changeEmailBtn.Size = new System.Drawing.Size(62, 56);
            this.changeEmailBtn.TabIndex = 14;
            this.changeEmailBtn.UseVisualStyleBackColor = true;
            this.changeEmailBtn.Click += new System.EventHandler(this.changeEmailBtn_Click);
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.Transparent;
            this.userIcon.Image = global::TestUI.Properties.Resources.Без_названия;
            this.userIcon.Location = new System.Drawing.Point(12, 12);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(341, 325);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userIcon.TabIndex = 1;
            this.userIcon.TabStop = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.changePassBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeEmailBtn);
            this.Controls.Add(this.statusUserLb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.eMailLb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userNameLb);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.userIcon);
            this.Name = "Profile";
            this.Text = "Личный кабинет";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundedPicBox userIcon;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label userNameLb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label eMailLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusUserLb;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton changeEmailBtn;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton changePassBtn;
    }
}