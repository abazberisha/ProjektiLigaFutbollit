namespace LigaFutbollit
{
    partial class ShikoLojtaret
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
            this.DtgLojtaret = new System.Windows.Forms.DataGridView();
            this.BtnKthehuRL = new System.Windows.Forms.Button();
            this.BtnFshij = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgLojtaret)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgLojtaret
            // 
            this.DtgLojtaret.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgLojtaret.Location = new System.Drawing.Point(11, 10);
            this.DtgLojtaret.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtgLojtaret.Name = "DtgLojtaret";
            this.DtgLojtaret.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DtgLojtaret.RowTemplate.Height = 24;
            this.DtgLojtaret.ShowCellErrors = false;
            this.DtgLojtaret.ShowCellToolTips = false;
            this.DtgLojtaret.ShowEditingIcon = false;
            this.DtgLojtaret.ShowRowErrors = false;
            this.DtgLojtaret.Size = new System.Drawing.Size(710, 396);
            this.DtgLojtaret.TabIndex = 0;
            this.DtgLojtaret.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgLojtaret_CellClick);
            this.DtgLojtaret.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgLojtaret_CellContentClick);
            this.DtgLojtaret.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgLojtaret_CellDoubleClick);
            // 
            // BtnKthehuRL
            // 
            this.BtnKthehuRL.Location = new System.Drawing.Point(530, 414);
            this.BtnKthehuRL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnKthehuRL.Name = "BtnKthehuRL";
            this.BtnKthehuRL.Size = new System.Drawing.Size(172, 29);
            this.BtnKthehuRL.TabIndex = 1;
            this.BtnKthehuRL.Text = "Kthehu te menaxhimi i Lojtareve";
            this.BtnKthehuRL.UseVisualStyleBackColor = true;
            this.BtnKthehuRL.Click += new System.EventHandler(this.BtnKthehuRL_Click);
            // 
            // BtnFshij
            // 
            this.BtnFshij.Location = new System.Drawing.Point(386, 414);
            this.BtnFshij.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnFshij.Name = "BtnFshij";
            this.BtnFshij.Size = new System.Drawing.Size(104, 29);
            this.BtnFshij.TabIndex = 3;
            this.BtnFshij.Text = "Fshij lojtar";
            this.BtnFshij.UseVisualStyleBackColor = true;
            this.BtnFshij.Click += new System.EventHandler(this.BtnFshij_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 414);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Per te ndryshuar te dhena te nje lojtari, klikoni dy here ne rreshtin e tij!";
            // 
            // ShikoLojtaret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFshij);
            this.Controls.Add(this.BtnKthehuRL);
            this.Controls.Add(this.DtgLojtaret);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShikoLojtaret";
            this.Text = "Shiko Lojtaret";
            this.Load += new System.EventHandler(this.ShikoLojtaret_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgLojtaret)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnKthehuRL;
        private System.Windows.Forms.Button BtnFshij;
        public System.Windows.Forms.DataGridView DtgLojtaret;
        private System.Windows.Forms.Label label1;
    }
}