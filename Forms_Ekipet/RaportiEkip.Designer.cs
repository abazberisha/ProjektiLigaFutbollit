namespace LigaFutbollit.Forms_Ekipet
{
    partial class RaportiEkip
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
            this.BtnKthehu = new System.Windows.Forms.Button();
            this.DtgRapEkip = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtgRapEkip)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKthehu
            // 
            this.BtnKthehu.Location = new System.Drawing.Point(294, 361);
            this.BtnKthehu.Name = "BtnKthehu";
            this.BtnKthehu.Size = new System.Drawing.Size(155, 58);
            this.BtnKthehu.TabIndex = 1;
            this.BtnKthehu.Text = "Kthehu";
            this.BtnKthehu.UseVisualStyleBackColor = true;
            this.BtnKthehu.Click += new System.EventHandler(this.BtnKthehu_Click);
            // 
            // DtgRapEkip
            // 
            this.DtgRapEkip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgRapEkip.Location = new System.Drawing.Point(74, 41);
            this.DtgRapEkip.Name = "DtgRapEkip";
            this.DtgRapEkip.RowTemplate.Height = 24;
            this.DtgRapEkip.Size = new System.Drawing.Size(641, 249);
            this.DtgRapEkip.TabIndex = 2;
            // 
            // RaportiEkip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 480);
            this.Controls.Add(this.DtgRapEkip);
            this.Controls.Add(this.BtnKthehu);
            this.Name = "RaportiEkip";
            this.Text = "RaportiEkip";
            ((System.ComponentModel.ISupportInitialize)(this.DtgRapEkip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnKthehu;
        public System.Windows.Forms.DataGridView DtgRapEkip;
    }
}