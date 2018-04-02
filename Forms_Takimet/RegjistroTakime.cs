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
using EntityLayer;

namespace LigaFutbollit
{
    public partial class RegjistroTakime : Form
    {
        List<ComboBox> ekipet = new List<ComboBox>();
        List<ComboBox> golShV = new List<ComboBox>();
        List<ComboBox> golShM = new List<ComboBox>();
        IGolat _golat;
        public RegjistroTakime(IGolat _g)
        {
            _golat = _g;
        }

        public RegjistroTakime()
        {
            InitializeComponent();
            //Vendosja e ekipeve ne cmb per ekipe Vendase
            //Variabla listaEkipV merr nga lista ekipet per tu vendosur ne comboboxin e ekipeve vendase
            var listaEkipV = RepositorySkuadra.listSkuadra;
           
            CmbSkuadraVendas.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbSkuadraVendas.DataSource = listaEkipV;
            CmbSkuadraVendas.DisplayMember = "emri";
            CmbSkuadraVendas.ValueMember = "emri";
            CmbSkuadraVendas.SelectedIndex = 0;
            ListaeLojtareveVendas();
            

            //Vendosja e ekipeve ne cmb per ekipe Mysafire
            //Variabla listaEkipM merr nga lista ekipet per tu vendosur ne comboboxin e ekipeve mysafire

            //Metoda BindingContext e perdorim qe ComboBoxi i ekipeve mysafire te jete korrekt me listen
            //si dhe permes kesaj metode mundesoj qe me vone te mos perseriten ekipet e njejta ne te dy selektimet
            var listaEkipM = RepositorySkuadra.listSkuadra;
            CmbSkuadraMysafir.BindingContext = new BindingContext();
            CmbSkuadraMysafir.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbSkuadraMysafir.DataSource = listaEkipM;
            CmbSkuadraMysafir.DisplayMember = "emri";
            CmbSkuadraMysafir.ValueMember = "emri";
            CmbSkuadraMysafir.SelectedIndex = 0;
            ListaeLojtareveMusafir();
           

            //Ne listen e ekipeve shtohen itemat e comboboxave
            ekipet.Add(CmbSkuadraMysafir);
            ekipet.Add(CmbSkuadraVendas);

            //ComboBox-et per Golashenuesit
            CmbGolShV.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbGolShM.DropDownStyle = ComboBoxStyle.DropDownList;
           
        }

        private void BtnKthehuRegj_Click(object sender, EventArgs e)
        {
            MenaxhoTakime menTak = new MenaxhoTakime();
            this.Hide();
            menTak.FormClosed += Form_Closing_Handler;
            menTak.Show();
        }

        private void BtnRegjTakim_Click(object sender, EventArgs e)
        {
            try
            {
                //Ne butonin Regjistro Takim inicializojme permes kontruktorin instancen e klases Takimi
                Takimi takimi = new Takimi(CmbSkuadraVendas.SelectedValue.ToString(), CmbSkuadraMysafir.SelectedValue.ToString(),
                    int.Parse(txtRezultatiVendas.Text), int.Parse(txtRezultatiMysafir.Text),
                    int.Parse(txtGoditjetVendas.Text), int.Parse(txtGoditjetMysafir.Text),
                    int.Parse(txtFauletVendas.Text), int.Parse(txtFauletVendas.Text),
                    int.Parse(txtOffsidetVendas.Text), int.Parse(txtOffsidetMysafir.Text),
                    int.Parse(txtCorneratVendas.Text), int.Parse(txtCorneratMysafir.Text),
                    int.Parse(txtAsistimetVendas.Text), int.Parse(txtAsistimetMysafir.Text),
                    int.Parse(txtKartonatKuqeVendas.Text), int.Parse(txtKartonatKuqeMysafir.Text),
                    int.Parse(txtKartonatVerdhVendas.Text), int.Parse(txtKartonatVerdheMysafir.Text),
                    int.Parse(txtPosedimiVendas.Text), int.Parse(txtPosedimiMysafir.Text), dateTimePickerDataTakimit.Value);

                //Instanca e Takimit vendoset ne liste
                RepositoryTakime.RegjistroTakim(takimi);

                MessageBox.Show("Takimi u regjistrua me sukses");
            }
            catch(Exception ex)
            {
                throw;
           }
        }

        private void CmbSkuadraVendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ne kete bllok kodi mundesojme mos perseritjen e te njejtave ekipe ne nje takim
            ComboBox thisCB = sender as ComboBox;
            ListaeLojtareveVendas();
            if (CmbGolShV.Text != "")
            {
                nrGV.Enabled = true;
            }
            else
            {
                nrGV.Enabled = false;
            }
            if (thisCB.Text != "" && thisCB.Text != "Choose a team")
            {
                foreach (ComboBox cb in ekipet)
                {
                    //Pas validimit qe comboboxat nuk jane te zbrazet,
                    //e validojme qe te mos lejohet duplifikimi i ekipit
                    if (thisCB.Name != cb.Name && thisCB.Text == cb.Text && thisCB.Text != "" && cb.Text != "" )
                    {
                        MessageBox.Show("You cannot duplicate Teams." + "\r\n" + "\r\n"
                                     + "That option has been selected in " + "Away Team", "Error");
                      
                            thisCB.SelectedIndex = 0;
                        
                        break;
                    }
                }
            }

           
            
        }

        private void CmbSkuadraMysafir_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox thisCB = sender as ComboBox;
            ListaeLojtareveMusafir();

            if (CmbGolShM.Text != "")
            {
                nrGM.Enabled = true;
            }
            else
            {
                nrGM.Enabled = false;
            }
            if (thisCB.Text != "" && thisCB.Text != "Choose a team")
            {
                foreach (ComboBox cb in ekipet)
                {
                    if (thisCB.Name != cb.Name && thisCB.Text == cb.Text && thisCB.Text != "" && cb.Text != "")
                    {
                        MessageBox.Show("You cannot duplicate Teams." + "\r\n" + "\r\n"
                                     + "That option has been selected in " + "Home Team", "Error");
                        
                            thisCB.SelectedIndex = 0;
                        
                        break;
                    }
                }
            }

        

        }

        public void ListaeLojtareveVendas()
        {
            CmbGolShV.Items.Clear();
            var objectRep = RepositoryLojtar.listLojtari.Where(x => x.Ekipi == CmbSkuadraVendas.Text);

            if (objectRep?.Count() > 0)
            {
                objectRep.ToList().ForEach(x => CmbGolShV.Items.Add(x.Emri));
                CmbGolShV.SelectedIndex = 0;
            }

            golShV.Add(CmbGolShV);
           
           
        }
        public void ListaeLojtareveMusafir()
        {
            CmbGolShM.Items.Clear();
            var objectRep = RepositoryLojtar.listLojtari.Where(x => x.Ekipi == CmbSkuadraMysafir.Text);

            if (objectRep?.Count() > 0)
            {
                objectRep.ToList().ForEach(x => CmbGolShM.Items.Add(x.Emri));
                CmbGolShM.SelectedIndex = 0;
            }

            golShM.Add(CmbGolShM);
        }
        public static int golatTotalVendas = 0;
        private void BtnRuajGolaShV_Click(object sender, EventArgs e)
        {
            int golatVendas = 0;
            try
            {
                golatVendas = Convert.ToInt32(txtRezultatiVendas.Value);

                golatTotalVendas += Convert.ToInt32(nrGV.Value);
                if (nrGV.Value != 0 || txtRezultatiVendas.Value != 0)
                {

                    if (golatTotalVendas > golatVendas)
                    {
                        golatTotalVendas -= Convert.ToInt32(nrGV.Value);
                        throw new Exception();
                    }
                    else
                    {
                        Goli g = new Goli(CmbGolShV.Text, Convert.ToInt32(nrGV.Value));

                        _golat.RegjistroGolat(g);

                        var lojtarRef = RepositoryLojtar.listLojtari.Where(x => x.Emri == CmbGolShV.Text);
                        lojtarRef.ToList().ForEach(x => x.Golat += Convert.ToInt32(nrGV.Value));

                    }
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch(Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageBox.Show("Ju lutem jepni nje numer te golave nuk lejohet 0!");
                }
                else
                {
                    MessageBox.Show("Golat e shenuara nga nje lojtar nuk mund te jene me shume se rezultati i ekipit!");
                }
            }
        }



        public static int golatTotalMusafir = 0;

        private void BtnRuajGolaShM_Click(object sender, EventArgs e)
        {
           
            try
            {
                 int golatMusafir = Convert.ToInt32(txtRezultatiMysafir.Value);
                 golatTotalMusafir += Convert.ToInt32(nrGM.Value);
                if (nrGV.Value != 0 || txtRezultatiVendas.Value != 0)
                {
                    if (golatTotalMusafir > golatMusafir)
                    {
                        golatTotalMusafir -= Convert.ToInt32(nrGM.Value);
                        throw new Exception();
                    }
                    else
                    {
                        Goli g = new Goli(CmbGolShM.Text, Convert.ToInt32(nrGM.Value));
                        _golat.RegjistroGolat(g);
                        var lojtarRef = RepositoryLojtar.listLojtari.Where(x => x.Emri == CmbGolShM.Text);
                        lojtarRef.ToList().ForEach(x => x.Golat += Convert.ToInt32(nrGM.Value));
                    }
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageBox.Show("Ju lutem jepni nje numer te golave nuk lejohet 0!");
                }
                else
                {
                    MessageBox.Show("Golat e shenuara nga nje lojtar nuk mund te jene me shume se rezultati i ekipit!");
                }
            }
        }

        private void CmbGolShV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CmbGolShV.Text != "")
            {
                nrGV.Enabled = true;
            }
        }

        private void CmbGolShM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbGolShM.Text != "")
            {
                nrGM.Enabled = true;
            }
        }

        private void RegjistroTakime_Load(object sender, EventArgs e)
        {
            ListaeLojtareveVendas();
            ListaeLojtareveMusafir();
           

        }

        public void Form_Closing_Handler(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
