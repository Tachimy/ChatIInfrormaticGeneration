namespace TestUI
{
    partial class Chat
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
            this.msgBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.msgLimitLb = new System.Windows.Forms.Label();
            this.senMsgButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgBox
            // 
            this.msgBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.msgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msgBox.Location = new System.Drawing.Point(0, 0);
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msgBox.Size = new System.Drawing.Size(1196, 66);
            this.msgBox.TabIndex = 2;
            this.msgBox.TextChanged += new System.EventHandler(this.msgBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.senMsgButton);
            this.panel1.Controls.Add(this.msgBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 66);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.msgLimitLb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1263, 34);
            this.panel2.TabIndex = 5;
            // 
            // msgLimitLb
            // 
            this.msgLimitLb.AutoSize = true;
            this.msgLimitLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msgLimitLb.Location = new System.Drawing.Point(12, 8);
            this.msgLimitLb.Name = "msgLimitLb";
            this.msgLimitLb.Size = new System.Drawing.Size(16, 20);
            this.msgLimitLb.TabIndex = 0;
            this.msgLimitLb.Text = "-";
            // 
            // senMsgButton
            // 
            this.senMsgButton.FlatAppearance.BorderSize = 0;
            this.senMsgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.senMsgButton.IconChar = FontAwesome.Sharp.IconChar.Comment;
            this.senMsgButton.IconColor = System.Drawing.Color.Black;
            this.senMsgButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.senMsgButton.Location = new System.Drawing.Point(1202, -3);
            this.senMsgButton.Name = "senMsgButton";
            this.senMsgButton.Size = new System.Drawing.Size(61, 66);
            this.senMsgButton.TabIndex = 3;
            this.senMsgButton.UseVisualStyleBackColor = true;
            this.senMsgButton.Click += new System.EventHandler(this.senMsgButton_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1263, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Chat";
            this.Text = "Чат";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox msgBox;
        private FontAwesome.Sharp.IconButton senMsgButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label msgLimitLb;
    }
}