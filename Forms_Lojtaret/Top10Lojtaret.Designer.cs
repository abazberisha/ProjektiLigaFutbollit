namespace LigaFutbollit.Forms_Lojtaret
{
    partial class Top10Lojtaret
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
            this.DtgTop10 = new System.Windows.Forms.DataGridView();
            this.BtnKthehu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgTop10)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgTop10
            // 
            this.DtgTop10.AllowUserToAddRows = false;
            this.DtgTop10.AllowUserToDeleteRows = false;
            this.DtgTop10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgTop10.Location = new System.Drawing.Point(12, 12);
            this.DtgTop10.Name = "DtgTop10";
            this.DtgTop10.RowTemplate.Height = 24;
            this.DtgTop10.Size = new System.Drawing.Size(618, 386);
            this.DtgTop10.TabIndex = 0;
            // 
            // BtnKthehu
            // 
            this.BtnKthehu.Location = new System.Drawing.Point(273, 424);
            this.BtnKthehu.Name = "BtnKthehu";
            this.BtnKthehu.Size = new System.Drawing.Size(111, 56);
            this.BtnKthehu.TabIndex = 1;
            this.BtnKthehu.Text = "Kthehu";
            this.BtnKthehu.UseVisualStyleBackColor = true;
            this.BtnKthehu.Click += new System.EventHandler(this.BtnKthehu_Click);
            // 
            // Top10Lojtaret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 492);
            this.Controls.Add(this.BtnKthehu);
            this.Controls.Add(this.DtgTop10);
            this.Name = "Top10Lojtaret";
            this.Text = "Top 10 Lojtaret e Ligës";
            ((System.ComponentModel.ISupportInitialize)(this.DtgTop10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgTop10;
        private System.Windows.Forms.Button BtnKthehu;
    }
}