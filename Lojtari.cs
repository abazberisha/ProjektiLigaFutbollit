using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityLayer
{
    public enum Pozicionet
    {
        Portier,
        Mbrojtes,
        Mesfushor,
        Sulmues
    }
    public class Lojtari : Personi
    {
        
        Skuadra dt = new Skuadra();
        private string _ekipi;
        private int _id, _numri, _golat, _asistimet;
        private static int _counterID = 0;
        private int _ekipiID;
        private Pozicionet _pozicioni;

        #region String Props
   
        public Pozicionet Pozicioni
        {
            get { return _pozicioni; }
            set { _pozicioni = value; }
        }
        public string Ekipi
        {
            get { return _ekipi; }
            set { _ekipi = value; }
        }
        #endregion
        #region Int Props

        public int EkipiID
        {
            get
            {
                return dt.TeamID;
            }
            set
            {
                _ekipiID = dt.TeamID;
            }
        }
        public int L_ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Numri
        {
            get { return _numri; }
            set { _numri = value; }
        }
        public int Golat
        {
            get { return _golat; }
            set { _golat = value; }
        }
        public int Asistimet
        {
            get { return _asistimet; }
            set { _asistimet = value; }
        }
        #endregion
        public Lojtari(){ }

        public Lojtari(string emri, string mbiemri, string shtetesia,string adresa,
                        Pozicionet pozicioni, string ekipi, int mosha,int nrKontaktit,decimal rroga,
                        int numri, int golat, int asistimet) : base(emri, mbiemri, shtetesia,adresa,mosha,nrKontaktit,rroga)
        {
            //ID eshte atributi unik i instances lojtari qe me nevojitet per manipulimin e tij
            //Counter ID eshte variabla qe ruan vlerat pas qdo krijimi te nje instance,
            //counterID na hyn ne pune me vone gjate programit.
            EkipiID = dt.TeamID;
            L_ID = ++_counterID;
            Shtetesia = shtetesia;
            Pozicioni = pozicioni;
            Ekipi = ekipi;
            Numri = numri;
            Golat = golat;
            Asistimet = asistimet;
        }
    }
}
