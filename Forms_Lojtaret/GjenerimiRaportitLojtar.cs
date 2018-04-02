using DataAccLayer;
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

namespace LigaFutbollit.Forms_Lojtaret
{
    
    public partial class GjenerimiRaportit_Lojtar : Form
    {
        public static int idLojt = 0;
        public static Lojtari GetLojtari { get; set; }
        public GjenerimiRaportit_Lojtar()
        {
            InitializeComponent();
            DtgRapLojtar.DataSource = RepositoryLojtar.listLojtari;
            DtgRapLojtar.Columns["Emri"].DisplayIndex = 0;
            DtgRapLojtar.Columns["Mbiemri"].DisplayIndex = 1;
            DtgRapLojtar.Columns["Shtetesia"].DisplayIndex = 2;
            DtgRapLojtar.Columns["Mosha"].DisplayIndex = 3;
            DtgRapLojtar.Columns["Ekipi"].DisplayIndex = 4;
            DtgRapLojtar.Columns["Numri"].DisplayIndex = 5;
            DtgRapLojtar.Columns["Golat"].DisplayIndex = 6;
            DtgRapLojtar.Columns["Asistimet"].DisplayIndex = 7;
        }

        private void BtnGjenero_Click(object sender, EventArgs e)
        {
            try
            {
                RaportiLojtar rapL = new RaportiLojtar();
                this.Hide();
                rapL.FormClosed += Form_Closing_Handler;
                idLojt = int.Parse(DtgRapLojtar.SelectedRows[0].Cells[3].Value.ToString());

                rapL.DtgRapLojtar.DataSource = RepositoryLojtar.listLojtari.Where(x => x.L_ID == idLojt).ToList(); 
                rapL.Show();
            }
            catch
            {
                MessageBox.Show("Ju lutem klikoni ne fillim te rreshtit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnKthehu_Click(object sender, EventArgs e)
        {
            
            ShikoLojtaret shikL = new ShikoLojtaret();
            this.Hide();
            shikL.FormClosed += Form_Closing_Handler;
            shikL.Show();
        }

        public void Form_Closing_Handler(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
