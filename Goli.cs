using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Goli
    {
        private string _golashenuesi;
        private int _numriGolave;
        public static int goliId = 0;

        public Goli()
        {

        }

        public Goli(string golashenuesi,int nrGolave)
        {
            goliId++;
            Golashenuesi = golashenuesi;
            NrGolave = nrGolave;
        }

        #region CompositeProps
        public string Golashenuesi
        {
            get { return _golashenuesi; }
            set { _golashenuesi = value; }
        }

        #endregion
        public int NrGolave
        {
            get { return _numriGolave; }
            set { _numriGolave = value; }
        }

    }
}   