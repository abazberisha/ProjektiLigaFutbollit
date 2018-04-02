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

namespace LigaFutbollit
{
    public partial class ShtoEkip : Form
    {
        public ShtoEkip()
        {
            InitializeComponent();
        }

        private void BtnKthehuRegj_Click(object sender, EventArgs e)
        {
            MenaxhoEkipet menaEK = new MenaxhoEkipet();
            this.Hide();
            menaEK.FormClosed += Form_Closing_Handler;
            menaEK.Show();
        }

        private void BtnShtoE_Click(object sender, EventArgs e)
        {
            
            //Inicializimi i objektit te skuadrave nga konstruktori
            Skuadra s = new Skuadra(txtEmriEk.Text, txtTrajneriEk.Text, int.Parse(txtRanguEk.Text),
                                    int.Parse(txtVitiTh.Text), int.Parse(txtFitoretEk.Text),
                                    int.Parse(txtBarazimetEk.Text), int.Parse(txtHumbjetEk.Text),
                                    int.Parse(txtLojetEk.Text), int.Parse(txtPiketEk.Text),
                                    int.Parse(txtGolAvgEk.Text));

            //Regjistrimi i Skuadrave ne liste
            RepositorySkuadra.RegjistroSkuader(s);

            MessageBox.Show("Ekipi u regjistrua me sukses");
        }

        public void Form_Closing_Handler(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
