namespace TestUI
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.opText = new System.Windows.Forms.TextBox();
            this.opValueText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addDict = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.loginUserTb = new System.Windows.Forms.TextBox();
            this.changeRoleBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.usersPanel = new System.Windows.Forms.Panel();
            this.usersDg = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Панель администратора";
            // 
            // opText
            // 
            this.opText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opText.Location = new System.Drawing.Point(47, 94);
            this.opText.Multiline = true;
            this.opText.Name = "opText";
            this.opText.Size = new System.Drawing.Size(308, 60);
            this.opText.TabIndex = 1;
            // 
            // opValueText
            // 
            this.opValueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opValueText.Location = new System.Drawing.Point(47, 191);
            this.opValueText.Multiline = true;
            this.opValueText.Name = "opValueText";
            this.opValueText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.opValueText.Size = new System.Drawing.Size(471, 237);
            this.opValueText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Термин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Определение";
            // 
            // addDict
            // 
            this.addDict.Location = new System.Drawing.Point(373, 101);
            this.addDict.Name = "addDict";
            this.addDict.Size = new System.Drawing.Size(148, 51);
            this.addDict.TabIndex = 5;
            this.addDict.Text = "Добавить элемент";
            this.addDict.UseVisualStyleBackColor = true;
            this.addDict.Click += new System.EventHandler(this.addDict_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(586, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Имя пользователя: ";
            // 
            // loginUserTb
            // 
            this.loginUserTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginUserTb.Location = new System.Drawing.Point(815, 59);
            this.loginUserTb.Multiline = true;
            this.loginUserTb.Name = "loginUserTb";
            this.loginUserTb.Size = new System.Drawing.Size(223, 33);
            this.loginUserTb.TabIndex = 7;
            // 
            // changeRoleBtn
            // 
            this.changeRoleBtn.Location = new System.Drawing.Point(1057, 53);
            this.changeRoleBtn.Name = "changeRoleBtn";
            this.changeRoleBtn.Size = new System.Drawing.Size(119, 44);
            this.changeRoleBtn.TabIndex = 8;
            this.changeRoleBtn.Text = "Назначить";
            this.changeRoleBtn.UseVisualStyleBackColor = true;
            this.changeRoleBtn.Click += new System.EventHandler(this.changeRoleBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(773, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Назначение администратора";
            // 
            // usersPanel
            // 
            this.usersPanel.Controls.Add(this.usersDg);
            this.usersPanel.Location = new System.Drawing.Point(591, 136);
            this.usersPanel.Name = "usersPanel";
            this.usersPanel.Size = new System.Drawing.Size(712, 544);
            this.usersPanel.TabIndex = 10;
            // 
            // usersDg
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.usersDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.usersDg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersDg.Location = new System.Drawing.Point(0, 0);
            this.usersDg.Name = "usersDg";
            this.usersDg.RowHeadersWidth = 51;
            this.usersDg.RowTemplate.Height = 24;
            this.usersDg.Size = new System.Drawing.Size(712, 544);
            this.usersDg.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Имя пользователя";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Статус администратора";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 786);
            this.Controls.Add(this.usersPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.changeRoleBtn);
            this.Controls.Add(this.loginUserTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addDict);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.opValueText);
            this.Controls.Add(this.opText);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Панель администратора";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.usersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox opText;
        private System.Windows.Forms.TextBox opValueText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addDict;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginUserTb;
        private System.Windows.Forms.Button changeRoleBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel usersPanel;
        private System.Windows.Forms.DataGridView usersDg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}