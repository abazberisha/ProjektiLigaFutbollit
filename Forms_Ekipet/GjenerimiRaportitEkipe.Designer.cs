namespace LigaFutbollit.Forms_Ekipet
{
    partial class GjenRapEkip
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
            this.DtgGjenRE = new System.Windows.Forms.DataGridView();
            this.BtnKthehu = new System.Windows.Forms.Button();
            this.BtnGjenR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgGjenRE)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgGjenRE
            // 
            this.DtgGjenRE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgGjenRE.Location = new System.Drawing.Point(12, 12);
            this.DtgGjenRE.Name = "DtgGjenRE";
            this.DtgGjenRE.RowTemplate.Height = 24;
            this.DtgGjenRE.Size = new System.Drawing.Size(868, 410);
            this.DtgGjenRE.TabIndex = 0;
            // 
            // BtnKthehu
            // 
            this.BtnKthehu.Location = new System.Drawing.Point(597, 448);
            this.BtnKthehu.Name = "BtnKthehu";
            this.BtnKthehu.Size = new System.Drawing.Size(114, 47);
            this.BtnKthehu.TabIndex = 2;
            this.BtnKthehu.Text = "BtnKthehu";
            this.BtnKthehu.UseVisualStyleBackColor = true;
            this.BtnKthehu.Click += new System.EventHandler(this.BtnKthehu_Click);
            // 
            // BtnGjenR
            // 
            this.BtnGjenR.Location = new System.Drawing.Point(155, 448);
            this.BtnGjenR.Name = "BtnGjenR";
            this.BtnGjenR.Size = new System.Drawing.Size(129, 47);
            this.BtnGjenR.TabIndex = 3;
            this.BtnGjenR.Text = "Gjenero Raportin";
            this.BtnGjenR.UseVisualStyleBackColor = true;
            this.BtnGjenR.Click += new System.EventHandler(this.BtnGjenR_Click_1);
            // 
            // GjenRapEkip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 521);
            this.Controls.Add(this.BtnGjenR);
            this.Controls.Add(this.BtnKthehu);
            this.Controls.Add(this.DtgGjenRE);
            this.Name = "GjenRapEkip";
            this.Text = "Gjenerimi i Raporteve per Ekipe";
            ((System.ComponentModel.ISupportInitialize)(this.DtgGjenRE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgGjenRE;
        private System.Windows.Forms.Button BtnKthehu;
        private System.Windows.Forms.Button BtnGjenR;
    }
}