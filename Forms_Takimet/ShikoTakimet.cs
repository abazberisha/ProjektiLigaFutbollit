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

namespace LigaFutbollit
{
    public partial class ShikoTakimet : Form
    {
        public ShikoTakimet()
        {
            //Ne kete bllok kam fshehur te gjitha kolonat qe kane detaje te takimit
            //dhe ne kete dritare kam lene te shikueshme vetem emrat e dy ekipeve qe kane luajtur,
            //per me shume informata do te shikohet nje forme tjeter.
            InitializeComponent();
            dataGridShiko.DataSource = RepositoryTakime.listTakimi;
            dataGridShiko.Columns[2].Visible = false;
            dataGridShiko.Columns[3].Visible = false;
            dataGridShiko.Columns[4].Visible = false;
            dataGridShiko.Columns[5].Visible = false;
            dataGridShiko.Columns[6].Visible = false;
            dataGridShiko.Columns[7].Visible = false;
            dataGridShiko.Columns[8].Visible = false;
            dataGridShiko.Columns[9].Visible = false;
            dataGridShiko.Columns[10].Visible = false;
            dataGridShiko.Columns[11].Visible = false;
            dataGridShiko.Columns[12].Visible = false;
            dataGridShiko.Columns[13].Visible = false;
            dataGridShiko.Columns[14].Visible = false;
            dataGridShiko.Columns[15].Visible = false;
            dataGridShiko.Columns[16].Visible = false;
            dataGridShiko.Columns[17].Visible = false;
            dataGridShiko.Columns[18].Visible = false;
            dataGridShiko.Columns[19].Visible = false;
            dataGridShiko.Columns[20].Visible = false;
            dataGridShiko.Columns[0].HeaderText = "Ekipi Vendas";
            dataGridShiko.Columns[1].HeaderText = "Ekipi Mysafir";


        }
        
        private void DataGridShiko_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ne kete bllok kam perdor eventin e DoubleClick-ut ne qeli te datagridit,
            //kam bere futjen e te dhenave ne variablin "teDhenat" permes Lambda Expression.
            //Pas kesaj kur te publikohen detajet e nje takimi, kjo forme mundeson qe te dhenat te
            //paraqiten per User-in.
            string ekipiv = dataGridShiko.SelectedRows[0].Cells[0].Value.ToString();
            string ekipim = dataGridShiko.SelectedRows[0].Cells[1].Value.ToString();
            var context = RepositoryTakime.listTakimi;
            var teDhenat = context.Where(item => item.EkipiV.ToString() == ekipiv.ToString() && item.EkipiM.ToString() == ekipim.ToString()).FirstOrDefault();
            DetajetTakimi detajetTakimi = new DetajetTakimi();
            detajetTakimi.lblEkipiM.Text = teDhenat.EkipiM;
            detajetTakimi.lblEkipiV.Text = teDhenat.EkipiV;
            detajetTakimi.lblRezV.Text = teDhenat.RezultatiV.ToString();
            detajetTakimi.lblRezM.Text = teDhenat.RezultatiM.ToString();
            detajetTakimi.lblDataTak.Text = teDhenat.Data.ToString();
            detajetTakimi.lblCornerM.Text = teDhenat.CornerM.ToString();
            detajetTakimi.lblCornerV.Text = teDhenat.CornerV.ToString();
            detajetTakimi.lblAsistimetM.Text = teDhenat.AsistimetM.ToString();
            detajetTakimi.lblAsistimetV.Text = teDhenat.AsistimetV.ToString();
            detajetTakimi.lblFauleM.Text = teDhenat.FauletM.ToString();
            detajetTakimi.lblFauleV.Text = teDhenat.FauletV.ToString();
            detajetTakimi.lblGnpM.Text = teDhenat.GoditjetNePorteM.ToString();
            detajetTakimi.lblGnpV.Text = teDhenat.GoditjetNePorteV.ToString();
            detajetTakimi.lblOffSM.Text = teDhenat.OffsideM.ToString();
            detajetTakimi.lblOffSV.Text = teDhenat.OffsideV.ToString();
            detajetTakimi.lblKKM.Text = teDhenat.KartonaKM.ToString();
            detajetTakimi.lblKKV.Text = teDhenat.KartonaKV.ToString();
            detajetTakimi.lblKVM.Text = teDhenat.KartonaVM.ToString();
            detajetTakimi.lblKVV.Text = teDhenat.KartonaVV.ToString();
            detajetTakimi.lblPosM.Text = teDhenat.PosedimiM.ToString();
            detajetTakimi.lblPosV.Text = teDhenat.PosedimiV.ToString();
            detajetTakimi.Show();
            detajetTakimi.FormClosed += Form_Closing_Handler;
            this.Hide();

        }

        private void BtnKthehu_Click(object sender, EventArgs e)
        {
            MenaxhoTakime MenTak = new MenaxhoTakime();
            this.Hide();
            MenTak.FormClosed += Form_Closing_Handler;
            MenTak.Show();
        }

        public void Form_Closing_Handler(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
