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
using LigaFutbollit.Forms_Lojtaret;

namespace LigaFutbollit
{
    public partial class StatistikatForma : Form
    {
        public StatistikatForma()
        {
            InitializeComponent();
        }

        private void BtnKthehu_Click(object sender, EventArgs e)
        {
            IntroForm introF = new IntroForm();
            this.Hide();
            introF.FormClosed += Form_Closing_Handler;
            introF.Show();
        }

        private void BtnTop10_Click(object sender, EventArgs e)
        {
            Top10Lojtaret Top10 = new Top10Lojtaret();
            this.Hide();
            Top10.FormClosed += Form_Closing_Handler;
            Top10.Show();
        }

        public void Form_Closing_Handler(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
