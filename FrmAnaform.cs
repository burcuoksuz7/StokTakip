using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipProje
{
    public partial class FrmAnaform : Form
    {
        public FrmAnaform()
        {
            InitializeComponent();
        }

        private void BtnKategoriIslemleri_Click(object sender, EventArgs e)
        {
            FrmKategori fr = new FrmKategori();
            fr.Show();
        }

        private void BtnUrunIslemleri_Click(object sender, EventArgs e)
        {
            FrmUrunIslemleri fr = new FrmUrunIslemleri();
            fr.Show();
        }

        private void BtnIstatistikler_Click(object sender, EventArgs e)
        {
            FrmIstatistik fr = new FrmIstatistik();
            fr.Show();
        }

        private void BtnMusteri_Click(object sender, EventArgs e)
        {
            FrmMusteri fr = new FrmMusteri();
            fr.Show();
        }

        private void FrmAnaform_Load(object sender, EventArgs e)
        {

        }
    }
}
