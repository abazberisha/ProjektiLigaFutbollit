namespace LigaFutbollit.Forms_Lojtaret
{
    partial class GjenerimiRaportit_Lojtar
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
            this.DtgRapLojtar = new System.Windows.Forms.DataGridView();
            this.BtnGjenero = new System.Windows.Forms.Button();
            this.BtnKthehu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgRapLojtar)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgRapLojtar
            // 
            this.DtgRapLojtar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgRapLojtar.Location = new System.Drawing.Point(12, 12);
            this.DtgRapLojtar.Name = "DtgRapLojtar";
            this.DtgRapLojtar.RowTemplate.Height = 24;
            this.DtgRapLojtar.Size = new System.Drawing.Size(971, 473);
            this.DtgRapLojtar.TabIndex = 0;
            // 
            // BtnGjenero
            // 
            this.BtnGjenero.Location = new System.Drawing.Point(180, 491);
            this.BtnGjenero.Name = "BtnGjenero";
            this.BtnGjenero.Size = new System.Drawing.Size(196, 45);
            this.BtnGjenero.TabIndex = 2;
            this.BtnGjenero.Text = "Gjenero Raportin";
            this.BtnGjenero.UseVisualStyleBackColor = true;
            this.BtnGjenero.Click += new System.EventHandler(this.BtnGjenero_Click);
            // 
            // BtnKthehu
            // 
            this.BtnKthehu.Location = new System.Drawing.Point(641, 491);
            this.BtnKthehu.Name = "BtnKthehu";
            this.BtnKthehu.Size = new System.Drawing.Size(106, 45);
            this.BtnKthehu.TabIndex = 3;
            this.BtnKthehu.Text = "Kthehu";
            this.BtnKthehu.UseVisualStyleBackColor = true;
            this.BtnKthehu.Click += new System.EventHandler(this.BtnKthehu_Click);
            // 
            // GjenerimiRaportit_Lojtar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 548);
            this.Controls.Add(this.BtnKthehu);
            this.Controls.Add(this.BtnGjenero);
            this.Controls.Add(this.DtgRapLojtar);
            this.Name = "GjenerimiRaportit_Lojtar";
            this.Text = "Gjenerimi i Raportit per Lojtar";
            ((System.ComponentModel.ISupportInitialize)(this.DtgRapLojtar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnGjenero;
        private System.Windows.Forms.Button BtnKthehu;
        public System.Windows.Forms.DataGridView DtgRapLojtar;
    }
}