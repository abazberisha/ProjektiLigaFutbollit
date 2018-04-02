using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccLayer;
using LigaFutbollit.Forms_Ekipet;

namespace LigaFutbollit
{
    public partial class MenaxhoEkipet : Form
    {
        public MenaxhoEkipet()
        {
            InitializeComponent();
        }

        private void BtnKthehu_Click(object sender, EventArgs e)
        {
            IntroForm introF = new LigaFutbollit.IntroForm();
            this.Hide();
            introF.FormClosed += Form_Closing_Handler;
            introF.Show();
        }

        private void BtnRegjEkip_Click(object sender, EventArgs e)
        {
            ShtoEkip shtoE = new LigaFutbollit.ShtoEkip();
            this.Hide();
            shtoE.FormClosed += Form_Closing_Handler;
            shtoE.Show();
        }

        private void BtnShikoEkip_Click(object sender, EventArgs e)
        {
         
            ShikoEkipet shikoEk = new LigaFutbollit.ShikoEkipet();
            this.Hide();
            shikoEk.FormClosed += Form_Closing_Handler;
            shikoEk.Show();
        }

        private void BtnGjenR_Click(object sender, EventArgs e)
        {
            GjenRapEkip gjenRE = new GjenRapEkip();
            this.Hide();
            gjenRE.FormClosed += Form_Closing_Handler;
            gjenRE.Show();
        }

        public void Form_Closing_Handler(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void shtoEkipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShikoEkipet shikoEk = new LigaFutbollit.ShikoEkipet();
            this.Hide();
            shikoEk.FormClosed += Form_Closing_Handler;
            shikoEk.Show();
        
    }

        private void regjistroEkipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShtoEkip shtoE = new LigaFutbollit.ShtoEkip();
            this.Hide();
            shtoE.FormClosed += Form_Closing_Handler;
            shtoE.Show();
        }

        private void gjeneroRaportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GjenRapEkip gjenRE = new GjenRapEkip();
            this.Hide();
            gjenRE.FormClosed += Form_Closing_Handler;
            gjenRE.Show();
        }

        private void kthehuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntroForm introF = new LigaFutbollit.IntroForm();
            this.Hide();
            introF.FormClosed += Form_Closing_Handler;
            introF.Show();
        }
    }
}
