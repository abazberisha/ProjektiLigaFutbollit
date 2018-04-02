using EntityLayer;
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

namespace LigaFutbollit.Forms_Lojtaret
{
    public partial class RaportiLojtar : Form
    {
        public RaportiLojtar()
        {
            InitializeComponent();
        }

        private void BtnKthehu_Click(object sender, EventArgs e)
        {
            GjenerimiRaportit_Lojtar gjenRL = new GjenerimiRaportit_Lojtar();
            this.Hide();
            gjenRL.FormClosed += Form_Closing_Handler;
            gjenRL.Show();
        }

        private void RaportiLojtar_Load(object sender, EventArgs e)
        {
           

        }

        private void DtgRapLojtar_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
        
        }

        public void Form_Closing_Handler(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
