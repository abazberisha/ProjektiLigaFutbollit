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

namespace LigaFutbollit
{
    public partial class EditoLojtar : Form
    {
        public EditoLojtar()
        {
            InitializeComponent();
            txtLID.Enabled = false;
            CmbPozicioni.DataSource = Enum.GetValues(typeof(Pozicionet));
            CmbPozicioni.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEkipi.ReadOnly = true;
        }

        public void VendosNeTxtB(Lojtari l)
        {
            //Metoda VendosNeTxtB merr lojtarin e selektuar nga DataGridi dhe e vendos
            //ne formen e Editimit te lojtareve
            txtLID.Text = l.L_ID.ToString();
            lblObjLojtari.Text = l.Emri + " " + l.Mbiemri;
            txtEmri.Text = l.Emri;
            txtMbiemri.Text = l.Mbiemri;
            txtShtetesia.Text = l.Shtetesia;
            CmbPozicioni.SelectedIndex = (int)l.Pozicioni;
            txtEkipi.Text = l.Ekipi;
            txtMosha.Text = l.Mosha.ToString();
            txtNumri.Text = l.Numri.ToString();
            txtGolat.Text = l.Golat.ToString();
            txtAsistimet.Text = l.Asistimet.ToString();
        }

        private void BtnRuajNdr_Click(object sender, EventArgs e)
        {
            //Permes metodes EditoLojtar i japim parametrat duke iu referu
            //lojtarit te selektuar dhe keto te dhena percillen ne listen e objekteve
            //te lojtareve dhe iu mbishkruhen te dhenat
            RepositoryLojtar.EditoLojtar(int.Parse(txtLID.Text), txtEmri.Text, txtMbiemri.Text,
                                         int.Parse(txtMosha.Text), (Pozicionet)CmbPozicioni.SelectedItem, txtShtetesia.Text,
                                         txtEkipi.Text, int.Parse(txtGolat.Text), int.Parse(txtAsistimet.Text),
                                         int.Parse(txtNumri.Text));

            MessageBox.Show(txtEmri.Text + " " + txtMbiemri.Text + "u editua me sukses", "Update",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnKthehu_Click(object sender, EventArgs e)
        {
            ShikoLojtaret shk = new ShikoLojtaret();
            shk.Show();
            shk.FormClosed += Form_Closing_Handler;
            this.Hide();
        }

        public void Form_Closing_Handler(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
