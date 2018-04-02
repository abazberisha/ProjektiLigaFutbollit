using System;
using System.Windows.Forms;
using EntityLayer;
using LigaFutbollit;
using DataAccLayer;

namespace LigaFutbollit
{
    public partial class ShtoLojtar : Form
    {
        public ShtoLojtar()
        {
            InitializeComponent();
            //CmbEkipet
            var lista = RepositorySkuadra.listSkuadra;
            CmbEkipi.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEkipi.DisplayMember = "emri";
            CmbEkipi.ValueMember = "L_ID";
            CmbEkipi.DataSource = lista;
            //CmbPozicioni
            CmbPozicioni.DataSource = Enum.GetValues(typeof(Pozicionet));
            
        }

        private void BtnKthehuRegj_Click(object sender, EventArgs e)
        {
            MenaxhoLojtaret menaxhoLojtaret = new MenaxhoLojtaret();
            this.Hide();
            menaxhoLojtaret.FormClosed += Form_Closing_Handler;
            menaxhoLojtaret.Show();
        }

        private void BtnRuajLojtar_Click(object sender, EventArgs e)
        {
            Lojtari lojtari = new Lojtari(txtEmri.Text, txtMbiemri.Text, txtShtetesia.Text, txtAdresa.Text, (Pozicionet)CmbPozicioni.SelectedItem, CmbEkipi.Text,
            int.Parse(txtMosha.Text), int.Parse(txtNrK.Text), int.Parse(txtRroga.Text), int.Parse(txtNumri.Text), int.Parse(txtGolat.Text), int.Parse(txtAsistimet.Text));

            RepositoryLojtar.RegjistroLojtar(lojtari);
            
            MessageBox.Show("Lojtari u regjistrua me sukses");
        }

        private void CmbEkipi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Form_Closing_Handler(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
