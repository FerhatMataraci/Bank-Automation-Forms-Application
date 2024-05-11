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
    public partial class ParaIslemleri : Form
    {
        private Banka banka = new Banka();
        private int musteriNumarasi;
        private int islem;
        private List<BireyselMusteri> BireyselMusteriList = new List<BireyselMusteri>();
        public ParaIslemleri(Banka banka, int musteriNumarasi, List<BireyselMusteri> BireyselMusteriList)
        {
            this.banka = banka;
            this.musteriNumarasi = musteriNumarasi;
            this.BireyselMusteriList = BireyselMusteriList;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYatırma_Click(object sender, EventArgs e)
        {
            double miktar = double.Parse(txtParaGiris.Text);
            int islem = 1;

            this.islem = islem;

            BireyselMusteri bireyselMusteri = new BireyselMusteri();
            bireyselMusteri.ParaYatir(BireyselMusteriList, musteriNumarasi, miktar);

            MessageBox.Show("Yeni bakiye: " + banka.BireyselMusteriList.Find(x => x.musteriNumarasi == musteriNumarasi).Bakiye);
            banka.GelenPara += miktar;
             

            FrmBankaArayuz frmBankaArayuz = Application.OpenForms.OfType<FrmBankaArayuz>().FirstOrDefault();
            if (frmBankaArayuz != null)
            {
                frmBankaArayuz.HesapHareketleriYazdir(miktar,islem);
                frmBankaArayuz.BakiyeGuncelle(banka.BireyselMusteriList.Find(x => x.musteriNumarasi == musteriNumarasi).Bakiye);
            }
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            double miktar = double.Parse(txtParaGiris.Text);
            int islem = 2;
            
            this.islem = islem;

            BireyselMusteri bireyselMusteri = new BireyselMusteri();
            bireyselMusteri.ParaCek(BireyselMusteriList, musteriNumarasi, miktar);

            MessageBox.Show("Yeni bakiye: " + banka.BireyselMusteriList.Find(x => x.musteriNumarasi == musteriNumarasi).Bakiye);

            banka.GidenPara += miktar;

            FrmBankaArayuz frmBankaArayuz = Application.OpenForms.OfType<FrmBankaArayuz>().FirstOrDefault();
            if (frmBankaArayuz != null)
            {
                frmBankaArayuz.HesapHareketleriYazdir(miktar, islem);
                frmBankaArayuz.BakiyeGuncelle(banka.BireyselMusteriList.Find(x => x.musteriNumarasi == musteriNumarasi).Bakiye);
            }
            
        }
    }
}
