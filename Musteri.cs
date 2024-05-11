using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevCFinal
{
    public class Musteri
    {
        public decimal TCKimlikNo { get; set; }
        public int musteriNumarasi { get; set; }
        public double Bakiye { get; set; }

        public string AdSoyad { get; set; }

        public string Sifre { get; set; }
        public double SicilNo { get; set; }

        public void ParaYatir(List<BireyselMusteri> musteriListesi, int musteriNo, double miktar)
        {

            foreach (BireyselMusteri musteri in musteriListesi)
            {
                if (musteri.musteriNumarasi == musteriNo)
                {
                    musteri.Bakiye += miktar;
                    break;
                }
            }
        }

        public void ParaCek(List<BireyselMusteri> musteriListesi, int musteriNo, double miktar)
        {
            foreach (BireyselMusteri musteri in musteriListesi)
            {
                if (musteri.musteriNumarasi == musteriNo)
                {
                    musteri.Bakiye -= miktar;
                    break;
                }
            }
        }


    }
}
