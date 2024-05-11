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
    public partial class KayıtForm : Form
    {
        private List<BireyselMusteri> BireyselMusteriList = new List<BireyselMusteri>();
        public KayıtForm(List<BireyselMusteri>BireyselMusteriList)
        {
            this.BireyselMusteriList = BireyselMusteriList;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbTicariMusteri.Checked == true) 
            {
                Random random = new Random();
                int MusteriNoRandom = random.Next(1000, 9999);

                Random random1 = new Random();
                double SicilNoRandom = random.Next(1000000, 9999999);





                BireyselMusteriList.Add(new BireyselMusteri
                {
                    TCKimlikNo = Convert.ToInt32(txtTCkimlik.Text),
                    AdSoyad = txtAdSoyad.Text,
                    musteriNumarasi = MusteriNoRandom,
                    Sifre = txtSifre.Text,
                    Bakiye = Convert.ToInt32(txtBakiye.Text),
                    SicilNo = SicilNoRandom

                });

                MessageBox.Show("SİZE ÖZEL OLUŞTURULAN MÜŞTERİ NUMARANIZ:  " + MusteriNoRandom.ToString());
            }
            
            else 
            { 
                Random random = new Random();
                int MusteriNoRandom=random.Next(1000,9999);
            


            
                BireyselMusteriList.Add(new BireyselMusteri { TCKimlikNo = Convert.ToInt32(txtTCkimlik.Text), AdSoyad = txtAdSoyad.Text, 
                    musteriNumarasi = MusteriNoRandom, Sifre = txtSifre.Text, Bakiye = Convert.ToInt32(txtBakiye.Text)
                });

                MessageBox.Show("SİZE ÖZEL OLUŞTURULAN MÜŞTERİ NUMARANIZ:  " + MusteriNoRandom.ToString());

            }




        }

        private void KayıtForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginIslemleri loginIslemleri = new LoginIslemleri();
            loginIslemleri.Show();
            
        }
    }
}
