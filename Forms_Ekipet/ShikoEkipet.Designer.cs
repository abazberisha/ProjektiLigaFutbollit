namespace LigaFutbollit
{
    partial class ShikoEkipet
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
            this.dtgEkipet = new System.Windows.Forms.DataGridView();
            this.btnMenaxhoEkipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEkipet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEkipet
            // 
            this.dtgEkipet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEkipet.Location = new System.Drawing.Point(1, 12);
            this.dtgEkipet.Name = "dtgEkipet";
            this.dtgEkipet.RowTemplate.Height = 24;
            this.dtgEkipet.Size = new System.Drawing.Size(904, 444);
            this.dtgEkipet.TabIndex = 0;
            // 
            // btnMenaxhoEkipe
            // 
            this.btnMenaxhoEkipe.Location = new System.Drawing.Point(455, 462);
            this.btnMenaxhoEkipe.Name = "btnMenaxhoEkipe";
            this.btnMenaxhoEkipe.Size = new System.Drawing.Size(238, 45);
            this.btnMenaxhoEkipe.TabIndex = 1;
            this.btnMenaxhoEkipe.Text = "Kthehu te menaxhimi i ekipeve";
            this.btnMenaxhoEkipe.UseVisualStyleBackColor = true;
            this.btnMenaxhoEkipe.Click += new System.EventHandler(this.BtnMenaxhoEkipe_Click);
            // 
            // ShikoEkipet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 519);
            this.Controls.Add(this.btnMenaxhoEkipe);
            this.Controls.Add(this.dtgEkipet);
            this.Name = "ShikoEkipet";
            this.Text = "Shiko Ekipet";
            this.Load += new System.EventHandler(this.ShikoEkipet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEkipet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEkipet;
        private System.Windows.Forms.Button btnMenaxhoEkipe;
    }
}