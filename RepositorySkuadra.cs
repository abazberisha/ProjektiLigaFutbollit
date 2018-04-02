using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccLayer
{
    public class RepositorySkuadra
    {
        //Lista e skuadrave
        public static List<Skuadra> listSkuadra = new List<Skuadra>();

        //Metoda per regjistrimin e skuadrave ne liste
        public static void RegjistroSkuader(Skuadra s)
        {
            listSkuadra.Add(s);
        }

        //Metoda per kthimin e skuadrave nga lista
        public static List<Skuadra> MerrSkuadra()
        {
            return listSkuadra;
        }
    }
}
