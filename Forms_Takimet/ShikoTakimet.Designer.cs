namespace LigaFutbollit
{
    partial class ShikoTakimet
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
            this.dataGridShiko = new System.Windows.Forms.DataGridView();
            this.BtnKthehu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShiko)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridShiko
            // 
            this.dataGridShiko.AllowUserToAddRows = false;
            this.dataGridShiko.AllowUserToDeleteRows = false;
            this.dataGridShiko.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridShiko.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridShiko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridShiko.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridShiko.Location = new System.Drawing.Point(229, 12);
            this.dataGridShiko.Name = "dataGridShiko";
            this.dataGridShiko.ReadOnly = true;
            this.dataGridShiko.RowTemplate.Height = 24;
            this.dataGridShiko.Size = new System.Drawing.Size(325, 438);
            this.dataGridShiko.TabIndex = 0;
            this.dataGridShiko.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridShiko_CellDoubleClick);
            // 
            // BtnKthehu
            // 
            this.BtnKthehu.Location = new System.Drawing.Point(618, 461);
            this.BtnKthehu.Name = "BtnKthehu";
            this.BtnKthehu.Size = new System.Drawing.Size(143, 71);
            this.BtnKthehu.TabIndex = 1;
            this.BtnKthehu.Text = "Kthehu";
            this.BtnKthehu.UseVisualStyleBackColor = true;
            this.BtnKthehu.Click += new System.EventHandler(this.BtnKthehu_Click);
            // 
            // ShikoTakimet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 544);
            this.Controls.Add(this.BtnKthehu);
            this.Controls.Add(this.dataGridShiko);
            this.Name = "ShikoTakimet";
            this.Text = "Shiko Takimet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShiko)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridShiko;
        private System.Windows.Forms.Button BtnKthehu;
    }
}