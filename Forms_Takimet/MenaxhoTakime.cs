using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LigaFutbollit
{
    public partial class MenaxhoTakime : Form
    {
        public MenaxhoTakime()
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

        private void BtnRegjTakim_Click(object sender, EventArgs e)
        {
            RegjistroTakime regjTak = new RegjistroTakime();
            this.Hide();
            regjTak.FormClosed += Form_Closing_Handler;
            regjTak.Show();
        }

        private void BtnShikTak_Click(object sender, EventArgs e)
        {
            ShikoTakimet shikTak = new ShikoTakimet();
            this.Hide();
            shikTak.FormClosed += Form_Closing_Handler;
            shikTak.Show();
        }

        public void Form_Closing_Handler(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
