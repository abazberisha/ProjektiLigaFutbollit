using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccLayer;
using EntityLayer;
using LigaFutbollit.Forms_Lojtaret;

namespace LigaFutbollit
{
    public partial class MenaxhoLojtaret : Form
    {
        public MenaxhoLojtaret()
        {
            InitializeComponent();
        }

        private void BtnRegjistroLojtar_Click(object sender, EventArgs e)
        {
            ShtoLojtar shtoL = new ShtoLojtar();
            shtoL.Show();
            shtoL.FormClosed += Form_Closing_Handler;
            this.Hide();
        }

        private void BtnShikoLojtar_Click(object sender, EventArgs e)
        {

            ShikoLojtaret shikoLojtaret = new ShikoLojtaret();
            this.Hide();
            shikoLojtaret.FormClosed += Form_Closing_Handler;
            shikoLojtaret.Show();

        }

        private void BtnKthehu_Click(object sender, EventArgs e)
        {
            IntroForm introf = new LigaFutbollit.IntroForm();
            this.Hide();
            introf.FormClosed += Form_Closing_Handler;
            introf.Show();
        }

        private void MenaxhoLojtaret_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void BtnRaport_Click(object sender, EventArgs e)
        {
            GjenerimiRaportit_Lojtar gjenRap = new GjenerimiRaportit_Lojtar();
            this.Hide();
            gjenRap.FormClosed += Form_Closing_Handler;
            gjenRap.Show();
        }

        private void MenaxhoLojtaret_Load(object sender, EventArgs e)
        {

        }

        private void BtnGjenRap_Click(object sender, EventArgs e)
        {
            GjenerimiRaportit_Lojtar gjenRap = new GjenerimiRaportit_Lojtar();
            this.Hide();
            gjenRap.ShowDialog();
        }

        public void Form_Closing_Handler(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
