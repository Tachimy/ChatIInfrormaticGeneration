namespace TestUI
{
    partial class changePassForm
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
            this.changePassBtn = new System.Windows.Forms.Button();
            this.passTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changePassBtn
            // 
            this.changePassBtn.FlatAppearance.BorderSize = 0;
            this.changePassBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.changePassBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.changePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassBtn.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePassBtn.Location = new System.Drawing.Point(176, 129);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(167, 48);
            this.changePassBtn.TabIndex = 18;
            this.changePassBtn.Text = "Обновить";
            this.changePassBtn.UseVisualStyleBackColor = true;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // passTb
            // 
            this.passTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.passTb.Location = new System.Drawing.Point(39, 66);
            this.passTb.Multiline = true;
            this.passTb.Name = "passTb";
            this.passTb.Size = new System.Drawing.Size(439, 39);
            this.passTb.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label1.Location = new System.Drawing.Point(99, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Введите новый пароль";
            // 
            // changePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 227);
            this.Controls.Add(this.changePassBtn);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.label1);
            this.Name = "changePassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение пароля";
            this.Load += new System.EventHandler(this.changePassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changePassBtn;
        private System.Windows.Forms.TextBox passTb;
        private System.Windows.Forms.Label label1;
    }
}