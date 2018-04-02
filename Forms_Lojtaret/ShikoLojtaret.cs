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
    public partial class ShikoLojtaret : Form
    {
        public static Lojtari GetLojtari { get; set; }
        public ShikoLojtaret()
        {
            InitializeComponent();
            //Ketu mbushim DataGridin per te shikuar lojtaret me objektet
            //e listes se lojtareve
            DtgLojtaret.DataSource = RepositoryLojtar.listLojtari;
            DtgLojtaret.Columns["Adresa"].Visible = false;
            DtgLojtaret.Columns["Rroga"].Visible = false;
            DtgLojtaret.Columns["NrKontaktit"].Visible = false;
            //DtgLojtaret.Columns["EkipiID"].Visible = false;
            //Ne rreshtin 25 kodi mundeson qe Atributi i ID-se te shfaqet ne
            //kolonen me index 0 pra kolonen e pare.

            //Renditja e kolonave ne forme
            DtgLojtaret.Columns["L_ID"].DisplayIndex = 1;
            DtgLojtaret.Columns["Emri"].DisplayIndex = 2;
            DtgLojtaret.Columns["Mbiemri"].DisplayIndex = 3;
            DtgLojtaret.Columns["Shtetesia"].DisplayIndex = 4;
            DtgLojtaret.Columns["Mosha"].DisplayIndex = 5;
            DtgLojtaret.Columns["Ekipi"].DisplayIndex = 6;
            DtgLojtaret.Columns["Numri"].DisplayIndex = 7;
            DtgLojtaret.Columns["Golat"].DisplayIndex = 8;
            DtgLojtaret.Columns["Asistimet"].DisplayIndex = 9;
        }

        private void BtnKthehuRL_Click(object sender, EventArgs e)
        {
            MenaxhoLojtaret menaxhoLojtaret = new MenaxhoLojtaret();
            this.Hide();
            menaxhoLojtaret.FormClosed += Form_Closing_Handler;
            menaxhoLojtaret.Show();
        }

        private void DtgLojtaret_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ne kete metode marrim lojtarin nga DataGrid dhe permes Try
            //tentojme ti kapim keto informata qe na duhen ne rastin e editimit te lojtareve.

            //Gjithashtu ne Catch shfaqim mesazhin e Errorit qe duhet klikuar ne fillim
            //te rreshtit sepse eshte e mundshme qe DataGridit ti editohet shkrimi ne klikim te qelise.
            Lojtari l = new Lojtari();

            try
            {
                l.Emri = DtgLojtaret.SelectedRows[0].Cells["Emri"].Value.ToString();
                l.Mbiemri = DtgLojtaret.SelectedRows[0].Cells["Mbiemri"].Value.ToString();
                l.Shtetesia = DtgLojtaret.SelectedRows[0].Cells["Shtetesia"].Value.ToString();
                l.Pozicioni = (Pozicionet)DtgLojtaret.SelectedRows[0].Cells["Pozicioni"].Value;
                l.Ekipi = DtgLojtaret.SelectedRows[0].Cells["Ekipi"].Value.ToString();
                l.L_ID = int.Parse(DtgLojtaret.SelectedRows[0].Cells["L_ID"].Value.ToString());
                l.Mosha = int.Parse(DtgLojtaret.SelectedRows[0].Cells["Mosha"].Value.ToString());
                l.Numri = int.Parse(DtgLojtaret.SelectedRows[0].Cells["Numri"].Value.ToString());
                l.Golat = int.Parse(DtgLojtaret.SelectedRows[0].Cells["Golat"].Value.ToString());
                l.Asistimet = int.Parse(DtgLojtaret.SelectedRows[0].Cells["Asistimet"].Value.ToString());
            }
            catch 
            {
                MessageBox.Show("Ju lutem klikoni ne fillim te rreshtit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GetLojtari = l;
        }

        private void DtgLojtaret_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nese nje rresht klikohet 2 here aktivizojme kete metode
            try
            {
                Lojtari l = new Lojtari();

                l.Emri = DtgLojtaret.SelectedRows[0].Cells["Emri"].Value.ToString();
                l.Mbiemri = DtgLojtaret.SelectedRows[0].Cells["Mbiemri"].Value.ToString();
                l.Shtetesia = DtgLojtaret.SelectedRows[0].Cells["Shtetesia"].Value.ToString();
                l.Pozicioni = (Pozicionet)DtgLojtaret.SelectedRows[0].Cells["Pozicioni"].Value;
                l.Ekipi = DtgLojtaret.SelectedRows[0].Cells["Ekipi"].Value.ToString();
                l.L_ID = int.Parse(DtgLojtaret.SelectedRows[0].Cells["L_ID"].Value.ToString());
                l.Mosha = int.Parse(DtgLojtaret.SelectedRows[0].Cells["Mosha"].Value.ToString());
                l.Numri = int.Parse(DtgLojtaret.SelectedRows[0].Cells["Numri"].Value.ToString());
                l.Golat = int.Parse(DtgLojtaret.SelectedRows[0].Cells["Golat"].Value.ToString());
                l.Asistimet = int.Parse(DtgLojtaret.SelectedRows[0].Cells["Asistimet"].Value.ToString());

                EditoLojtar edL = new EditoLojtar();
                this.Hide();
                edL.FormClosed += Form_Closing_Handler;
                edL.Show();

                edL.VendosNeTxtB(l);
            }
            catch(Exception ex)
            {
                throw;
            }

        }

        private void ShikoLojtaret_Load(object sender, EventArgs e)
        {
            //Ne procesin e Load-imit te formes ShikoLojtaret e mbushim
            //DataGridin me itemat e listes se lojtareve.
            DtgLojtaret.DataSource = RepositoryLojtar.listLojtari;
            DtgLojtaret.Columns["L_ID"].DisplayIndex = 0;
        }

        private void BtnFshij_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DtgLojtaret.SelectedRows[0].Cells["L_ID"].Value.ToString());
            RepositoryLojtar.FshiLojtar(id);
            DtgLojtaret.DataSource = null;
            DtgLojtaret.DataSource = RepositoryLojtar.listLojtari;
          
           
        }
        
        private void BtnGjenRap_Click(object sender, EventArgs e)
        {
            //Emri = DtgLojtaret.SelectedRows[0].Cells[0].Value.ToString();
            GjenerimiRaportit_Lojtar gjenRap = new GjenerimiRaportit_Lojtar();
            this.Hide();
            gjenRap.FormClosed += Form_Closing_Handler;
            gjenRap.Show();
        }

        public void Form_Closing_Handler(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DtgLojtaret_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
