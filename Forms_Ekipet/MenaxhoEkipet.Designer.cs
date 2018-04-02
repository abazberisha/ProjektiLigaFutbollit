namespace LigaFutbollit
{
    partial class MenaxhoEkipet
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regjistroEkipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shtoEkipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gjeneroRaportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kthehuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regjistroEkipToolStripMenuItem,
            this.shtoEkipToolStripMenuItem,
            this.gjeneroRaportToolStripMenuItem,
            this.kthehuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regjistroEkipToolStripMenuItem
            // 
            this.regjistroEkipToolStripMenuItem.Name = "regjistroEkipToolStripMenuItem";
            this.regjistroEkipToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.regjistroEkipToolStripMenuItem.Text = "Regjistro Ekip";
            this.regjistroEkipToolStripMenuItem.Click += new System.EventHandler(this.regjistroEkipToolStripMenuItem_Click);
            // 
            // shtoEkipToolStripMenuItem
            // 
            this.shtoEkipToolStripMenuItem.Name = "shtoEkipToolStripMenuItem";
            this.shtoEkipToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.shtoEkipToolStripMenuItem.Text = "Shiko Ekip";
            this.shtoEkipToolStripMenuItem.Click += new System.EventHandler(this.shtoEkipToolStripMenuItem_Click);
            // 
            // gjeneroRaportToolStripMenuItem
            // 
            this.gjeneroRaportToolStripMenuItem.Name = "gjeneroRaportToolStripMenuItem";
            this.gjeneroRaportToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.gjeneroRaportToolStripMenuItem.Text = "Gjenero Raport";
            this.gjeneroRaportToolStripMenuItem.Click += new System.EventHandler(this.gjeneroRaportToolStripMenuItem_Click);
            // 
            // kthehuToolStripMenuItem
            // 
            this.kthehuToolStripMenuItem.Name = "kthehuToolStripMenuItem";
            this.kthehuToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.kthehuToolStripMenuItem.Text = "Kthehu";
            this.kthehuToolStripMenuItem.Click += new System.EventHandler(this.kthehuToolStripMenuItem_Click);
            // 
            // MenaxhoEkipet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 375);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenaxhoEkipet";
            this.Text = "Menaxhimi i Ekipeve";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regjistroEkipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shtoEkipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gjeneroRaportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kthehuToolStripMenuItem;
    }
}