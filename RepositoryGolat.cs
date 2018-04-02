using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;


namespace DataAccLayer
{  public class RepositoryGolat : IGolat
    {
        //Lista per golat
        public static List<Goli> listGolat = new List<Goli>();

        //Metoda per regjistrimin e golave
        public void RegjistroGolat(Goli g)
        {
            listGolat.Add(g);
        }

        //Metoda per kthimin e golave
        public List<Goli> MerrGolat()
        {
            return listGolat;
        }
    }
  
}
