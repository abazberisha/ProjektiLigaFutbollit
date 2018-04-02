using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccLayer
{
    public class RepositoryLojtar
    {
        //Lista e lojtareve
        public static List<Lojtari> listLojtari = new List<Lojtari>();

        //Metoda per regjistrimin e lojtareve
        public static void RegjistroLojtar(Lojtari l)
        {
            listLojtari.Add(l);
        }

        //Metoda per kthimin e lojtareve
        public static List<Lojtari> MerrLojtar()
        {
            return listLojtari;
        }

        //Metoda per editimin e lojtareve
        public static void EditoLojtar(int id,string emri,string mbiemri,int mosha, Pozicionet pozicioni,
                                    string shtetesia,string ekipi, int golat,int asistimet,int numri)
        {
            //Variabli teDhenat merr informacionin mbi lojtarin qe po editohet dhe lidhet me ID-ne
            //e tij, qe ti referohemi objektit te duhur qe eshte selektuar pasi ID eshte unike
            Lojtari teDhenat = listLojtari.Where(item => item.L_ID.ToString() == id.ToString()).FirstOrDefault();
            if (teDhenat.L_ID == id)
            {
                teDhenat.Emri = emri;
                teDhenat.Mbiemri = mbiemri;
                teDhenat.Shtetesia = shtetesia;
                teDhenat.Pozicioni = pozicioni;
                teDhenat.Ekipi = ekipi;
                teDhenat.Mosha = mosha;
                teDhenat.Numri = numri;
                teDhenat.Golat = golat;
                teDhenat.Asistimet = asistimet;
            }
        }

        //Metoda per fshirjen e lojtarit
        public static void FshiLojtar(int id)
        {
            Lojtari lojtar = listLojtari.Where(item => item.L_ID.ToString() == id.ToString()).FirstOrDefault();
            if (lojtar.L_ID == id)
            {
                listLojtari.Remove(lojtar);
            }
        }
    }   
}
