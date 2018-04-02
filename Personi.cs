using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Personi //: POO16F3.Person
    {
        private string _emri, _mbiemri, _shtetesia, _adresa;
        //private string _shtetesia;
        private string PersonID;
        private int _mosha, _nrKontaktit;
        private decimal _rroga;
        public static int _personID = 0;

        #region StringProps
        public string Emri
        {
            get
            {
                return _emri;
            }
            set
            {
                _emri = value;
            }
        }
        public string Mbiemri
        {
            get
            {
                return _mbiemri;
            }
            set
            {
                _mbiemri = value;
            }
        }
        public string Shtetesia
        {
            get
            {
                return _shtetesia;
            }
            set
            {
                _shtetesia = value;
            }
        }
        public string Adresa
        {
            get
            {
                return _adresa;
            }
            set
            {
                _adresa = value;
            }
        }
        #endregion
        #region IntProps
        public int Mosha
        {
            get
            {
                return _mosha;
            }
            set
            {
                _mosha = value;
            }
        }
        public int NrKontaktit
        {
            get
            {
                return _nrKontaktit;
            }
            set
            {
                _nrKontaktit = value;
            }
        }
        public decimal Rroga
        {
            get
            {
                return _rroga;
            }
            set
            {
                _rroga = value;
            }
        }
        #endregion


        public Personi() { }

        public Personi(string emri, string mbiemri, string shtetesia, string adresa, int mosha,
                        int nrKontaktit, decimal rroga)
        {
            PersonID = (++_personID).ToString();
            this.Emri = emri;
            this.Mbiemri = mbiemri;
            this.Shtetesia = shtetesia;
            this.Adresa = adresa;
            this.Mosha = mosha;
            this.NrKontaktit = nrKontaktit;
            this.Rroga = rroga;
        }

    }
}
