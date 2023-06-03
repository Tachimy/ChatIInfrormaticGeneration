namespace TestUI
{
    partial class DictionaryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dictDg = new System.Windows.Forms.DataGridView();
            this.Термин = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Определение = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dictDg)).BeginInit();
            this.SuspendLayout();
            // 
            // dictDg
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dictDg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dictDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dictDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Термин,
            this.Определение});
            this.dictDg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dictDg.Location = new System.Drawing.Point(0, 0);
            this.dictDg.Name = "dictDg";
            this.dictDg.RowHeadersWidth = 51;
            this.dictDg.RowTemplate.Height = 24;
            this.dictDg.Size = new System.Drawing.Size(1034, 450);
            this.dictDg.TabIndex = 0;
            // 
            // Термин
            // 
            this.Термин.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Термин.DefaultCellStyle = dataGridViewCellStyle2;
            this.Термин.HeaderText = "Термин";
            this.Термин.MinimumWidth = 6;
            this.Термин.Name = "Термин";
            this.Термин.ReadOnly = true;
            // 
            // Определение
            // 
            this.Определение.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Определение.DefaultCellStyle = dataGridViewCellStyle3;
            this.Определение.HeaderText = "Определение";
            this.Определение.MinimumWidth = 6;
            this.Определение.Name = "Определение";
            this.Определение.ReadOnly = true;
            // 
            // DictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.dictDg);
            this.Name = "DictionaryForm";
            this.Text = "Словарь терминов";
            this.Load += new System.EventHandler(this.DictionaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dictDg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dictDg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Термин;
        private System.Windows.Forms.DataGridViewTextBoxColumn Определение;
    }
}