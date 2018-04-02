using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LigaFutbollit.Forms_Lojtaret
{
    public partial class Top10Lojtaret : Form
    {
        public Top10Lojtaret()
        {
            InitializeComponent();
            DtgTop10.RowCount = 10;
        }

        private void BtnKthehu_Click(object sender, EventArgs e)
        {
            StatistikatForma statF = new StatistikatForma();
            this.Hide();
            statF.FormClosed += Form_Closing_Handler;
            statF.Show();
        }

        public void Form_Closing_Handler(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
