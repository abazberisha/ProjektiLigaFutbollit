using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LigaFutbollit.Forms_Ekipet
{
    public partial class RaportiEkip : Form
    {
        public RaportiEkip()
        {
            InitializeComponent();
        }

        private void BtnKthehu_Click(object sender, EventArgs e)
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
    }
}
