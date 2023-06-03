namespace TestUI
{
    partial class changeEmailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.changeEmailBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите E-Mail";
            // 
            // emailTb
            // 
            this.emailTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.emailTb.Location = new System.Drawing.Point(12, 56);
            this.emailTb.Multiline = true;
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(439, 39);
            this.emailTb.TabIndex = 1;
            // 
            // changeEmailBtn
            // 
            this.changeEmailBtn.FlatAppearance.BorderSize = 0;
            this.changeEmailBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.changeEmailBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.changeEmailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeEmailBtn.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeEmailBtn.Location = new System.Drawing.Point(149, 119);
            this.changeEmailBtn.Name = "changeEmailBtn";
            this.changeEmailBtn.Size = new System.Drawing.Size(167, 48);
            this.changeEmailBtn.TabIndex = 15;
            this.changeEmailBtn.Text = "Обновить";
            this.changeEmailBtn.UseVisualStyleBackColor = true;
            this.changeEmailBtn.Click += new System.EventHandler(this.changeEmailBtn_Click);
            // 
            // changeEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 189);
            this.Controls.Add(this.changeEmailBtn);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.label1);
            this.Name = "changeEmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование почты";
            this.Load += new System.EventHandler(this.changeEmailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.Button changeEmailBtn;
    }
}