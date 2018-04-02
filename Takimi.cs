using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Takimi : POO16F3.Rezervim
    {
        private string _ekipiV, _ekipiM;
        private int _rezultatiV, _rezultatiM, _goditjetNePorteV,
            _goditjetNePorteM, _fauletV, _fauletM,
            _offsideV, _offsideM, _cornerV,
            _cornerM, _asistimetV, _asistimetM,
            _kartonaKV, _kartonaKM, _kartonaVV,
            _kartonaVM, _posedimiV, _posedimiM;
        //private DateTime _data;

        #region StringProps
        public string EkipiV
        {
            get { return _ekipiV; }
            set { _ekipiV = value; }
        }
        public string EkipiM
        {
            get { return _ekipiM; }
            set { _ekipiM = value; }
        }
        #endregion
        #region IntProps
        public int RezultatiV
        {
            get { return _rezultatiV; }
            set { _rezultatiV = value; }
        }
        public int RezultatiM
        {
            get { return _rezultatiM; }
            set { _rezultatiM = value; }
        }
        public int GoditjetNePorteV
        {
            get { return _goditjetNePorteV; }
            set { _goditjetNePorteV = value; }
        }
        public int GoditjetNePorteM
        {
            get { return _goditjetNePorteM; }
            set { _goditjetNePorteM = value; }
        }
        public int FauletV
        {
            get { return _fauletV; }
            set { _fauletV = value; }
        }
        public int FauletM
        {
            get { return _fauletM; }
            set { _fauletM = value; }
        }
        public int OffsideV
        {
            get { return _offsideV; }
            set { _offsideV = value; }
        }
        public int OffsideM
        {
            get { return _offsideM; }
            set { _offsideM = value; }
        }
        public int CornerV
        {
            get { return _cornerV; }
            set { _cornerV = value; }
        }
        public int CornerM
        {
            get { return _cornerM; }
            set { _cornerM = value; }
        }
        public int AsistimetV
        {
            get { return _asistimetV; }
            set { _asistimetV = value; }
        }
        public int AsistimetM
        {
            get { return _asistimetM; }
            set { _asistimetM = value; }
        }
        public int KartonaKV
        {
            get { return _kartonaKV; }
            set { _kartonaKV = value; }
        }
        public int KartonaKM
        {
            get { return _kartonaKM; }
            set { _kartonaKM = value; }
        }
        public int KartonaVV
        {
            get { return _kartonaVV; }
            set { _kartonaVV = value; }
        }
        public int KartonaVM
        {
            get { return _kartonaVM; }
            set { _kartonaVM = value; }
        }
        public int PosedimiV
        {
            get { return _posedimiV; }
            set { _posedimiV = value; }
        }
        public int PosedimiM
        {
            get { return _posedimiM; }
            set { _posedimiM = value; }
        }
        #endregion

        public Takimi()
        {

        }
        public Takimi(string ekipiV, string ekipiM, int rezultatiV, int rezultatiM, 
                        int goditjeNePorteV, int goditjeNePorteM, int fauletV, int fauletM,
                        int offsideV, int offsideM, int cornerV, int cornerM, int asistimetV, int asistimetM,
                        int kartonaKV, int kartonaKM, int kartonaVV, int kartonaVM, int posedimiV,
                        int posedimiM,DateTime dataTakimit)
        {
            EkipiV = ekipiV;
            EkipiM = ekipiM;
            RezultatiV = rezultatiV;
            RezultatiM = rezultatiM;
            GoditjetNePorteV = goditjeNePorteV;
            GoditjetNePorteM = goditjeNePorteM;
            FauletV = fauletV;
            FauletM = fauletM;
            OffsideV = offsideV;
            OffsideM = offsideM;
            CornerV = cornerV;
            CornerM = cornerM;
            AsistimetV = asistimetV;
            AsistimetM = asistimetM;
            KartonaKV = kartonaKV;
            KartonaKM = kartonaKM;
            KartonaVV = kartonaVV;
            KartonaVM = kartonaVM;
            PosedimiV = posedimiV;
            PosedimiM = posedimiM;
            Data = dataTakimit;
        }
    }
}
