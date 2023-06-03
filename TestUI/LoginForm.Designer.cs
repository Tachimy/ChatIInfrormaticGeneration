namespace TestUI
{
    partial class LoginForm
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
            this.minLb = new System.Windows.Forms.Label();
            this.exitLb = new System.Windows.Forms.Label();
            this.registerLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.authBtn = new System.Windows.Forms.Button();
            this.authPassTb = new System.Windows.Forms.TextBox();
            this.authLogTb = new System.Windows.Forms.TextBox();
            this.auth_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // minLb
            // 
            this.minLb.AutoSize = true;
            this.minLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.minLb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.minLb.Location = new System.Drawing.Point(352, 4);
            this.minLb.Name = "minLb";
            this.minLb.Size = new System.Drawing.Size(29, 32);
            this.minLb.TabIndex = 20;
            this.minLb.Text = "_";
            this.minLb.Click += new System.EventHandler(this.minLb_Click);
            // 
            // exitLb
            // 
            this.exitLb.AutoSize = true;
            this.exitLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.exitLb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.exitLb.Location = new System.Drawing.Point(391, 7);
            this.exitLb.Name = "exitLb";
            this.exitLb.Size = new System.Drawing.Size(33, 32);
            this.exitLb.TabIndex = 19;
            this.exitLb.Text = "X";
            this.exitLb.Click += new System.EventHandler(this.exitLb_Click);
            // 
            // registerLb
            // 
            this.registerLb.AutoSize = true;
            this.registerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.registerLb.Location = new System.Drawing.Point(246, 383);
            this.registerLb.Name = "registerLb";
            this.registerLb.Size = new System.Drawing.Size(99, 16);
            this.registerLb.TabIndex = 16;
            this.registerLb.Text = "Создайте его!";
            this.registerLb.Click += new System.EventHandler(this.registerLb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(138, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Нет аккаунта?";
            // 
            // authBtn
            // 
            this.authBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.authBtn.FlatAppearance.BorderSize = 2;
            this.authBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.authBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.authBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authBtn.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authBtn.Location = new System.Drawing.Point(156, 304);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(129, 61);
            this.authBtn.TabIndex = 14;
            this.authBtn.Text = "Войти";
            this.authBtn.UseVisualStyleBackColor = true;
            this.authBtn.Click += new System.EventHandler(this.authBtn_Click);
            // 
            // authPassTb
            // 
            this.authPassTb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authPassTb.Location = new System.Drawing.Point(126, 246);
            this.authPassTb.Multiline = true;
            this.authPassTb.Name = "authPassTb";
            this.authPassTb.PasswordChar = '*';
            this.authPassTb.Size = new System.Drawing.Size(235, 44);
            this.authPassTb.TabIndex = 13;
            // 
            // authLogTb
            // 
            this.authLogTb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authLogTb.Location = new System.Drawing.Point(128, 152);
            this.authLogTb.Multiline = true;
            this.authLogTb.Name = "authLogTb";
            this.authLogTb.Size = new System.Drawing.Size(235, 44);
            this.authLogTb.TabIndex = 12;
            // 
            // auth_label
            // 
            this.auth_label.AutoSize = true;
            this.auth_label.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auth_label.Location = new System.Drawing.Point(122, 54);
            this.auth_label.Name = "auth_label";
            this.auth_label.Size = new System.Drawing.Size(180, 33);
            this.auth_label.TabIndex = 11;
            this.auth_label.Text = "Авторизация";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TestUI.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(41, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestUI.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(41, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.minLb);
            this.Controls.Add(this.exitLb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registerLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authBtn);
            this.Controls.Add(this.authPassTb);
            this.Controls.Add(this.authLogTb);
            this.Controls.Add(this.auth_label);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label minLb;
        private System.Windows.Forms.Label exitLb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label registerLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.TextBox authPassTb;
        private System.Windows.Forms.TextBox authLogTb;
        private System.Windows.Forms.Label auth_label;
    }
}