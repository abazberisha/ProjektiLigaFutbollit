namespace LigaFutbollit
{
    partial class MenaxhoLojtaret
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
            this.BtnRegjistroLojtar = new System.Windows.Forms.Button();
            this.btnKthehu = new System.Windows.Forms.Button();
            this.btnShikoLojtar = new System.Windows.Forms.Button();
            this.BtnGjenRap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRegjistroLojtar
            // 
            this.BtnRegjistroLojtar.Location = new System.Drawing.Point(118, 90);
            this.BtnRegjistroLojtar.Name = "BtnRegjistroLojtar";
            this.BtnRegjistroLojtar.Size = new System.Drawing.Size(196, 69);
            this.BtnRegjistroLojtar.TabIndex = 0;
            this.BtnRegjistroLojtar.Text = "Regjistro Lojtar";
            this.BtnRegjistroLojtar.UseVisualStyleBackColor = true;
            this.BtnRegjistroLojtar.Click += new System.EventHandler(this.BtnRegjistroLojtar_Click);
            // 
            // btnKthehu
            // 
            this.btnKthehu.Location = new System.Drawing.Point(440, 293);
            this.btnKthehu.Name = "btnKthehu";
            this.btnKthehu.Size = new System.Drawing.Size(196, 69);
            this.btnKthehu.TabIndex = 4;
            this.btnKthehu.Text = "Kthehu";
            this.btnKthehu.UseVisualStyleBackColor = true;
            this.btnKthehu.Click += new System.EventHandler(this.BtnKthehu_Click);
            // 
            // btnShikoLojtar
            // 
            this.btnShikoLojtar.Location = new System.Drawing.Point(440, 90);
            this.btnShikoLojtar.Name = "btnShikoLojtar";
            this.btnShikoLojtar.Size = new System.Drawing.Size(196, 69);
            this.btnShikoLojtar.TabIndex = 5;
            this.btnShikoLojtar.Text = "Shiko Lojtaret";
            this.btnShikoLojtar.UseVisualStyleBackColor = true;
            this.btnShikoLojtar.Click += new System.EventHandler(this.BtnShikoLojtar_Click);
            // 
            // BtnGjenRap
            // 
            this.BtnGjenRap.Location = new System.Drawing.Point(118, 293);
            this.BtnGjenRap.Name = "BtnGjenRap";
            this.BtnGjenRap.Size = new System.Drawing.Size(196, 69);
            this.BtnGjenRap.TabIndex = 6;
            this.BtnGjenRap.Text = "Gjenero Raport";
            this.BtnGjenRap.UseVisualStyleBackColor = true;
            this.BtnGjenRap.Click += new System.EventHandler(this.BtnGjenRap_Click);
            // 
            // MenaxhoLojtaret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 473);
            this.Controls.Add(this.BtnGjenRap);
            this.Controls.Add(this.btnShikoLojtar);
            this.Controls.Add(this.btnKthehu);
            this.Controls.Add(this.BtnRegjistroLojtar);
            this.Name = "MenaxhoLojtaret";
            this.Text = "Menaxhimi i Lojtareve";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenaxhoLojtaret_FormClosed);
            this.Load += new System.EventHandler(this.MenaxhoLojtaret_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRegjistroLojtar;
        private System.Windows.Forms.Button btnKthehu;
        private System.Windows.Forms.Button btnShikoLojtar;
        private System.Windows.Forms.Button BtnGjenRap;
    }
}