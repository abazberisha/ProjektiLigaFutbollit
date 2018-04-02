namespace LigaFutbollit
{
    partial class StatistikatForma
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
            this.BtnTop10 = new System.Windows.Forms.Button();
            this.BtnKthehu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTop10
            // 
            this.BtnTop10.Location = new System.Drawing.Point(435, 55);
            this.BtnTop10.Name = "BtnTop10";
            this.BtnTop10.Size = new System.Drawing.Size(165, 111);
            this.BtnTop10.TabIndex = 0;
            this.BtnTop10.Text = "Shiko Top 10 Lojtaret e Ligës";
            this.BtnTop10.UseVisualStyleBackColor = true;
            this.BtnTop10.Click += new System.EventHandler(this.BtnTop10_Click);
            // 
            // BtnKthehu
            // 
            this.BtnKthehu.Location = new System.Drawing.Point(435, 271);
            this.BtnKthehu.Name = "BtnKthehu";
            this.BtnKthehu.Size = new System.Drawing.Size(165, 111);
            this.BtnKthehu.TabIndex = 1;
            this.BtnKthehu.Text = "Kthehu";
            this.BtnKthehu.UseVisualStyleBackColor = true;
            this.BtnKthehu.Click += new System.EventHandler(this.BtnKthehu_Click);
            // 
            // StatistikatForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 471);
            this.Controls.Add(this.BtnKthehu);
            this.Controls.Add(this.BtnTop10);
            this.Name = "StatistikatForma";
            this.Text = "Statistikat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTop10;
        private System.Windows.Forms.Button BtnKthehu;
    }
}