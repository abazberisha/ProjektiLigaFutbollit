using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccLayer
{
    public interface IGolat
    {
        void RegjistroGolat(Goli g);
        List<Goli> MerrGolat();
    }
}
