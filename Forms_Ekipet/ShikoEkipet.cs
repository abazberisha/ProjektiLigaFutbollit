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
using LigaFutbollit.Forms_Ekipet;

namespace LigaFutbollit
{
    public partial class ShikoEkipet : Form
    {
        public ShikoEkipet()
        {
            InitializeComponent();
            //Ketu behet mbushja e DataGridit "Ekipet" me itemat e listes te skuadrave
            dtgEkipet.DataSource = RepositorySkuadra.listSkuadra;
           
        }


        private void BtnMenaxhoEkipe_Click(object sender, EventArgs e)
        {
            MenaxhoEkipet menaxhEk = new MenaxhoEkipet();
            this.Hide();
            menaxhEk.FormClosed += Form_Closing_Handler;
            menaxhEk.Show();
        }

        private void GjenRapE_Click(object sender, EventArgs e)
        {
            GjenRapEkip gjenRap = new GjenRapEkip();
            this.Hide();
            gjenRap.FormClosed += Form_Closing_Handler;
            gjenRap.Show();
        }

        public void Form_Closing_Handler(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShikoEkipet_Load(object sender, EventArgs e)
        {
            CurrencyManager currentManager1 = (CurrencyManager)BindingContext[dtgEkipet.DataSource];
            currentManager1.SuspendBinding();
            dtgEkipet.Rows[0].Visible = false;
            currentManager1.ResumeBinding();
        }
    }
}
