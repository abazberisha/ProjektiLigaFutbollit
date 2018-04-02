using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccLayer
{
    public class RepositoryTakime
    {
        //Lista e takimeve
        public static List<Takimi> listTakimi = new List<Takimi>();

        //Metoda per regjistrimin e takimeve ne liste
        public static void RegjistroTakim(Takimi t)
        {
            listTakimi.Add(t);
        }

        //Metoda per te nxjerre takimet nga lista
        public static List<Takimi> MerrTakim()
        {
            return listTakimi;
        }
    }
}
