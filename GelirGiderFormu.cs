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
    public partial class GelirGiderFormu : Form
    { private Banka banka;
        public GelirGiderFormu(Banka banka)
        {
            this.banka = banka;
            InitializeComponent();
        }

        private void GelirGiderFormu_Load(object sender, EventArgs e)
        {
            double GidenPara = banka.GidenPara;
            double GelenPara = banka.GelenPara;
            double ToplamPara = banka.ToplamParaHesapla();
            lblToplamPara.Text = ToplamPara.ToString();
            lblGelir.Text = GelenPara.ToString();
            lblGider.Text = GidenPara.ToString();

        }
    }
}
