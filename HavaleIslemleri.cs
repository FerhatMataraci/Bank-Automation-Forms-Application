using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevCFinal
{
    public partial class HavaleIslemleri : Form
    {
        private Banka banka = new Banka();
        private int musteriNumarasi;
        private List<BireyselMusteri> BireyselMusteriList = new List<BireyselMusteri>();
        public HavaleIslemleri(Banka banka, int musteriNumarasi, List<BireyselMusteri> BireyselMusteriList)
        {
            this.banka = banka;
            this.musteriNumarasi = musteriNumarasi;
            this.BireyselMusteriList = BireyselMusteriList;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            double miktar = double.Parse(txtMiktar.Text);
            double oran = miktar / 50;
            double yenimiktar = miktar + oran;
            int gonderilenKisi = int.Parse(txtMusteriNo.Text);

            BireyselMusteri bireyselmusteri = BireyselMusteriList.Find(x => x.musteriNumarasi == gonderilenKisi);
            if (bireyselmusteri == null)
            {
                MessageBox.Show("Girdiğiniz müşteri numarası bulunamadı.");
            }

            else if (gonderilenKisi == musteriNumarasi)
            {
                MessageBox.Show("Aynı hesaba para gönderemezsiniz.");
            }

            else 
            { 
                if(banka.BireyselMusteriList.Find(x => x.musteriNumarasi == musteriNumarasi).SicilNo < 1000000) 
                { 
                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.ParaCek(BireyselMusteriList, musteriNumarasi, yenimiktar);

                    banka.GidenPara += yenimiktar;
                    MessageBox.Show("Yeni bakiye: " + banka.BireyselMusteriList.Find(x => x.musteriNumarasi == musteriNumarasi).Bakiye);

                    BireyselMusteri bireyselMusteri2 = new BireyselMusteri();
                    bireyselMusteri2.ParaYatir(BireyselMusteriList, gonderilenKisi, miktar);

                    MessageBox.Show("Gönderilen kişinin yeni bakiyesi: " + banka.BireyselMusteriList.Find(x => x.musteriNumarasi == gonderilenKisi).Bakiye);
                    banka.GelenPara += miktar;

                    FrmBankaArayuz frmBankaArayuz = Application.OpenForms.OfType<FrmBankaArayuz>().FirstOrDefault();

                    if (frmBankaArayuz != null)
                    {
                        frmBankaArayuz.HesapHaraketleriHavale(yenimiktar, gonderilenKisi);
                        frmBankaArayuz.BakiyeGuncelle(banka.BireyselMusteriList.Find(x => x.musteriNumarasi == musteriNumarasi).Bakiye);
                    }
                }

                else if(banka.BireyselMusteriList.Find(x => x.musteriNumarasi == musteriNumarasi).SicilNo > 1000000)
                {
                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.ParaCek(BireyselMusteriList, musteriNumarasi, miktar);

                    MessageBox.Show("Yeni bakiye: " + banka.BireyselMusteriList.Find(x => x.musteriNumarasi == musteriNumarasi).Bakiye);

                    BireyselMusteri bireyselMusteri2 = new BireyselMusteri();
                    bireyselMusteri2.ParaYatir(BireyselMusteriList, gonderilenKisi, miktar);

                    MessageBox.Show("Gönderilen kişinin yeni bakiyesi: " + banka.BireyselMusteriList.Find(x => x.musteriNumarasi == gonderilenKisi).Bakiye);

                    FrmBankaArayuz frmBankaArayuz = Application.OpenForms.OfType<FrmBankaArayuz>().FirstOrDefault();

                    if (frmBankaArayuz != null)
                    {
                        frmBankaArayuz.HesapHaraketleriHavale(miktar, gonderilenKisi);
                        frmBankaArayuz.BakiyeGuncelle(banka.BireyselMusteriList.Find(x => x.musteriNumarasi == musteriNumarasi).Bakiye);
                    }
                }
            }

        }
    }
}
