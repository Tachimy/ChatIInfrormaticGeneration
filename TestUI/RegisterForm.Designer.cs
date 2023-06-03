namespace TestUI
{
    partial class RegisterForm
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
            this.regBtn = new System.Windows.Forms.Button();
            this.regPassTb = new System.Windows.Forms.TextBox();
            this.regLogTb = new System.Windows.Forms.TextBox();
            this.reg_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minLb = new System.Windows.Forms.Label();
            this.exitLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // regBtn
            // 
            this.regBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.regBtn.FlatAppearance.BorderSize = 2;
            this.regBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.regBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regBtn.Location = new System.Drawing.Point(88, 307);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(274, 61);
            this.regBtn.TabIndex = 17;
            this.regBtn.Text = "Зарегистрировать";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // regPassTb
            // 
            this.regPassTb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regPassTb.Location = new System.Drawing.Point(125, 240);
            this.regPassTb.Multiline = true;
            this.regPassTb.Name = "regPassTb";
            this.regPassTb.PasswordChar = '*';
            this.regPassTb.Size = new System.Drawing.Size(235, 44);
            this.regPassTb.TabIndex = 16;
            // 
            // regLogTb
            // 
            this.regLogTb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLogTb.Location = new System.Drawing.Point(127, 146);
            this.regLogTb.Multiline = true;
            this.regLogTb.Name = "regLogTb";
            this.regLogTb.Size = new System.Drawing.Size(235, 44);
            this.regLogTb.TabIndex = 15;
            // 
            // reg_label
            // 
            this.reg_label.AutoSize = true;
            this.reg_label.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_label.Location = new System.Drawing.Point(153, 53);
            this.reg_label.Name = "reg_label";
            this.reg_label.Size = new System.Drawing.Size(180, 33);
            this.reg_label.TabIndex = 14;
            this.reg_label.Text = "Регистрация";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TestUI.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(40, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestUI.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(40, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // minLb
            // 
            this.minLb.AutoSize = true;
            this.minLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.minLb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.minLb.Location = new System.Drawing.Point(349, 6);
            this.minLb.Name = "minLb";
            this.minLb.Size = new System.Drawing.Size(29, 32);
            this.minLb.TabIndex = 22;
            this.minLb.Text = "_";
            this.minLb.Click += new System.EventHandler(this.minLb_Click);
            // 
            // exitLb
            // 
            this.exitLb.AutoSize = true;
            this.exitLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.exitLb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.exitLb.Location = new System.Drawing.Point(388, 9);
            this.exitLb.Name = "exitLb";
            this.exitLb.Size = new System.Drawing.Size(33, 32);
            this.exitLb.TabIndex = 21;
            this.exitLb.Text = "X";
            this.exitLb.Click += new System.EventHandler(this.exitLb_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 434);
            this.Controls.Add(this.minLb);
            this.Controls.Add(this.exitLb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.regPassTb);
            this.Controls.Add(this.regLogTb);
            this.Controls.Add(this.reg_label);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.TextBox regPassTb;
        private System.Windows.Forms.TextBox regLogTb;
        private System.Windows.Forms.Label reg_label;
        private System.Windows.Forms.Label minLb;
        private System.Windows.Forms.Label exitLb;
    }
}