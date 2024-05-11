using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevCFinal
{
    public class Banka
    {
        public double GelenPara { get; set; }
        public double GidenPara { get; set; }

        public List<BireyselMusteri> BireyselMusteriList = new List<BireyselMusteri>();

        public double ToplamParaHesapla()
        {
            double ToplamPara = 0;
            foreach(BireyselMusteri musteri in BireyselMusteriList)
            {
                ToplamPara += musteri.Bakiye;
            }

            return ToplamPara;
        }

    }
}
