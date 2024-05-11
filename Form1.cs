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
    public partial class FrmBankaArayuz : Form
    {
        private Banka banka = new Banka();
        private int musteriNumarasi;
        private List<BireyselMusteri> BireyselMusteriList = new List<BireyselMusteri>();

        


        public FrmBankaArayuz(Banka banka, int musteriNumarasi, List<BireyselMusteri> BireyselMusteriList)
        {
            this.banka = banka;
            this.musteriNumarasi = musteriNumarasi;
            this.BireyselMusteriList = BireyselMusteriList;
            InitializeComponent();
        }

        private void paraİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParaIslemleri paraIslemleri = new ParaIslemleri(banka, musteriNumarasi, BireyselMusteriList);
            paraIslemleri.MdiParent = this;
            paraIslemleri.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void havaleİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

            HavaleIslemleri havaleIslemleri = new HavaleIslemleri(banka, musteriNumarasi, BireyselMusteriList);
            havaleIslemleri.Show();


        }

        private void gelirGiderRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GelirGiderFormu gelirGiderFormu = new GelirGiderFormu(banka);
            gelirGiderFormu.Show();
                
        }


        public void HesapHareketleriYazdir(double miktar, int islem)
        {
            string text;
            string hareket;

            if(islem == 1)
            { 
                hareket = " +" + miktar.ToString();
                text = "Para yatırıldı: " + miktar + hareket;

                lvHesapHareketi.Items.Add(text);
    
            }

            if (islem == 2)
            {
                hareket = " -" + miktar.ToString();
                text = "Para yatırıldı: " + miktar + hareket;

                lvHesapHareketi.Items.Add(text);
            }
        }

        public void HesapHaraketleriHavale(double miktar, int musteriNo)
        {
            string hareket;
            string text;

            hareket = " -" + miktar.ToString();
            text = musteriNo + " Müşteri No'lu hesaba para yatırıldı: " + miktar + hareket;

            lvHesapHareketi.Items.Add(text);
        }

        private void hesapSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = banka.BireyselMusteriList.IndexOf(BireyselMusteriList.FirstOrDefault(m => m.musteriNumarasi == musteriNumarasi));
            if (index >= 0)
            {
                if(BireyselMusteriList.Find(x => x.musteriNumarasi == musteriNumarasi).Bakiye != 0)
                {
                    MessageBox.Show("Hesap silme işlemi sadece bakiye sıfırlandığında yapılabilir.");
                }
                else 
                { 
                    BireyselMusteriList.RemoveAt(index);
                    MessageBox.Show("Hesabınız başarıyla silindi.");
                    this.Close();
                }

            }
        }

        private void FrmBankaArayuz_Load(object sender, EventArgs e)
        {
            lblTcKimlikNo.Text = banka.BireyselMusteriList.Find(x => x.musteriNumarasi == musteriNumarasi).TCKimlikNo.ToString();
            lblMusteriNo.Text = musteriNumarasi.ToString();
            lblBakiye.Text = banka.BireyselMusteriList.Find(x => x.musteriNumarasi == musteriNumarasi).Bakiye.ToString();
            lblAdSoyad.Text = banka.BireyselMusteriList.Find(x => x.musteriNumarasi == musteriNumarasi).AdSoyad.ToString();
            if(banka.BireyselMusteriList.Find(x => x.musteriNumarasi == musteriNumarasi).SicilNo > 1000000)
            {
                lblSicilNo.Text = banka.BireyselMusteriList.Find(x => x.musteriNumarasi == musteriNumarasi).SicilNo.ToString();
            }
            else
            {
                lblSicilNo.Text = "Sicil numarası sadece ticari müşterilere verilir.";
            }
        }

        public void BakiyeGuncelle(double bakiye)
        {
            lblBakiye.Text = bakiye.ToString();
        }


    }
}
