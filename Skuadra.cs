using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{

    public class Skuadra
    {
        private string _emri, _trajneri;
        private int _rangu, _vitiTh, _fitore, _barazime, _humbje, _lojetLuajtura, _piketLiges, _golAverazhi;
        public static int teamid = 0;
        public int _teamID;
        //Lista e lojtarve
        public List<Lojtari> listaELojtarve = new List<Lojtari>();
    
        #region String Props
        public string Emri
        {
            get { return _emri; }
            set { _emri = value; }
        }

        public string Trajneri
        {
            get { return _trajneri; }
            set { _trajneri = value; }
        }
        #endregion
        #region Int Props
        public int TeamID
        {
            get
            {
                return _teamID;
            }
            set
            {
                _teamID = value;
             
            }
        }
        public int Rangu
        {
            get { return _rangu; }
            set { _rangu = value; }
        }
        public int VitiTh
        {
            get { return _vitiTh; }
            set { _vitiTh = value; }
        }
        public int Fitore
        {
            get { return _fitore; }
            set { _fitore = value; }
        }
        public int Barazime
        {
            get { return _barazime; }
            set { _barazime = value; }
        }
        public int Humbje
        {
            get { return _humbje; }
            set { _humbje = value; }
        }
        public int LojetLuajtura
        {
            get { return _lojetLuajtura; }
            set { _lojetLuajtura = value; }
        }
        public int PiketLiges
        {
            get { return _piketLiges; }
            set { _piketLiges = value; }
        }
        public int GolAverazhi
        {
            get { return _golAverazhi; }
            set { _golAverazhi = value; }
        }
        #endregion

        public Skuadra()
        {

        }
        public Skuadra(string emri, string trajneri, int rangu, int vitiTh,
                        int fitore, int barazime, int humbje, int lojetLuajtura,
                        int piketLiges, int golAverazhi)
        {
            TeamID = teamid++;
            Emri = emri;
            Trajneri = trajneri;
            Rangu = rangu;
            VitiTh = vitiTh;
            Fitore = fitore;
            Barazime = barazime;
            Humbje = humbje;
            LojetLuajtura = lojetLuajtura;
            PiketLiges = piketLiges;
            GolAverazhi = golAverazhi;
        }

    }
}
