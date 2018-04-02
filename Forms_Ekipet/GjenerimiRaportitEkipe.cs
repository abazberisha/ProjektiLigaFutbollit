using DataAccLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LigaFutbollit;

namespace LigaFutbollit.Forms_Ekipet
{
    public partial class GjenRapEkip : Form
    {
        public static int idEkipe = 0;
        public GjenRapEkip()
        {
            InitializeComponent();

            DtgGjenRE.DataSource = RepositorySkuadra.listSkuadra;
        }

        private void BtnKthehu_Click(object sender, EventArgs e)
        {
            MenaxhoEkipet menEk = new MenaxhoEkipet();
            this.Hide();
            menEk.FormClosed += Form_Closing_Handler;
            menEk.Show();
        }
        
        private void BtnGjenR_Click_1(object sender, EventArgs e)
        {
            try
            {
                RaportiEkip rapE = new RaportiEkip();
                idEkipe = int.Parse(DtgGjenRE.SelectedRows[0].Cells[2].Value.ToString());

                rapE.DtgRapEkip.DataSource = RepositorySkuadra.listSkuadra.Where(x => x.TeamID == idEkipe).ToList();
                this.Hide();
                rapE.FormClosed += Form_Closing_Handler;
                rapE.Show();
            }
            catch
            {
                MessageBox.Show("Ju lutem klikoni ne fillim te rreshtit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Form_Closing_Handler(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
