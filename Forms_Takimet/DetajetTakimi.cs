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
    public partial class DetajetTakimi : Form
    {
        public DetajetTakimi()
        {
            InitializeComponent();
        }

        private void BtnKthehu_Click(object sender, EventArgs e)
        {
            ShikoTakimet ShikTak = new ShikoTakimet();
            this.Hide();
            ShikTak.FormClosed += Form_Closing_Handler;
            ShikTak.Show();
        }

        public void Form_Closing_Handler(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
