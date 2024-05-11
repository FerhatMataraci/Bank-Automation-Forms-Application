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
    public partial class LoginIslemleri : Form
    {
        private List<BireyselMusteri> BireyselMusteriList = new List<BireyselMusteri>();
        private Banka banka = new Banka();
        public LoginIslemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int musteriNo = Convert.ToInt32(txtMusteriNo.Text);
            string sifre = txtSifre.Text;



            BireyselMusteri bireyselmusteri =BireyselMusteriList.Find(x => x.musteriNumarasi == musteriNo);
            if (bireyselmusteri != null)
            {
                FrmBankaArayuz hesap = new FrmBankaArayuz(banka, musteriNo, BireyselMusteriList);
                hesap.ShowDialog();
            }

           
            else
            {
                MessageBox.Show("Yanlış Müşteri Numarası veya şifre girdiniz.");
            }


        }

        private void LoginIslemleri_Load(object sender, EventArgs e)
        {
            Banka banka = new Banka();

            banka.BireyselMusteriList.Add(new BireyselMusteri { TCKimlikNo = 12332456782, AdSoyad = "Ahmet Demir", musteriNumarasi = 7777, Sifre = "1234", Bakiye = 3000});
            banka.BireyselMusteriList.Add(new BireyselMusteri { TCKimlikNo = 12355555322, AdSoyad = "Ali Yazar", musteriNumarasi = 5555, Sifre = "5678", Bakiye = 2100 });

            this.BireyselMusteriList = banka.BireyselMusteriList;
            this.banka = banka;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            KayıtForm kayıtForm = new KayıtForm(BireyselMusteriList);
            kayıtForm.Show();
            
        }
    }
}
