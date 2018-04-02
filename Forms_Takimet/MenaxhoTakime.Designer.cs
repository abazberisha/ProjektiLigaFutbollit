namespace LigaFutbollit
{
    partial class MenaxhoTakime
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
            this.BtnRegjTakim = new System.Windows.Forms.Button();
            this.BtnKthehu = new System.Windows.Forms.Button();
            this.BtnShikTak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRegjTakim
            // 
            this.BtnRegjTakim.Location = new System.Drawing.Point(101, 76);
            this.BtnRegjTakim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRegjTakim.Name = "BtnRegjTakim";
            this.BtnRegjTakim.Size = new System.Drawing.Size(94, 59);
            this.BtnRegjTakim.TabIndex = 0;
            this.BtnRegjTakim.Text = "Regjistro Takim";
            this.BtnRegjTakim.UseVisualStyleBackColor = true;
            this.BtnRegjTakim.Click += new System.EventHandler(this.BtnRegjTakim_Click);
            // 
            // BtnKthehu
            // 
            this.BtnKthehu.Location = new System.Drawing.Point(285, 250);
            this.BtnKthehu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnKthehu.Name = "BtnKthehu";
            this.BtnKthehu.Size = new System.Drawing.Size(94, 59);
            this.BtnKthehu.TabIndex = 1;
            this.BtnKthehu.Text = "Kthehu";
            this.BtnKthehu.UseVisualStyleBackColor = true;
            this.BtnKthehu.Click += new System.EventHandler(this.BtnKthehu_Click);
            // 
            // BtnShikTak
            // 
            this.BtnShikTak.Location = new System.Drawing.Point(285, 76);
            this.BtnShikTak.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnShikTak.Name = "BtnShikTak";
            this.BtnShikTak.Size = new System.Drawing.Size(94, 59);
            this.BtnShikTak.TabIndex = 3;
            this.BtnShikTak.Text = "Shiko Takime";
            this.BtnShikTak.UseVisualStyleBackColor = true;
            this.BtnShikTak.Click += new System.EventHandler(this.BtnShikTak_Click);
            // 
            // MenaxhoTakime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 380);
            this.Controls.Add(this.BtnShikTak);
            this.Controls.Add(this.BtnKthehu);
            this.Controls.Add(this.BtnRegjTakim);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenaxhoTakime";
            this.Text = "Menaxho Takimet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRegjTakim;
        private System.Windows.Forms.Button BtnKthehu;
        private System.Windows.Forms.Button BtnShikTak;
    }
}