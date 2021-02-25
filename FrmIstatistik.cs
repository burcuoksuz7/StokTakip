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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities1 db = new DbEntityUrunEntities1();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label2.Text = db.TBLKATEGORI.Count().ToString();  //kategorideki değerleri say (count) ve label2 ye yazdır.
            label3.Text = db.TBLURUN.Count().ToString();  //kategorideki değerleri say (count) ve label2 ye yazdır.
            label5.Text = db.TBLMUSTERI.Count(x=> x.DURUM==true).ToString(); //durumu true olan müşterileri getirir.
            label23.Text = db.TBLMUSTERI.Count(x => x.DURUM == false).ToString(); //durumu true olan müşterileri getirir.
            label9.Text = db.TBLURUN.Sum(x => x.STOK).ToString();  //toplama sum ile yapılır.
            label15.Text = db.TBLSATIS.Sum(z => z.FIYAT).ToString() + "₺";
            label7.Text = (from x in db.TBLURUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            label17.Text = (from x in db.TBLURUN orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            label11.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            label21.Text = db.TBLURUN.Count(x => x.KATEGORI == 2).ToString();
            label19.Text = db.TBLURUN.Count(x => x.KATEGORI == 3).ToString();
            label13.Text = (from x in db.TBLMUSTERI select x.SEHIR).Distinct().Count().ToString();
            label25.Text = db.TBLURUN.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            label27.Text = db.TBLURUN.Count(x => x.URUNAD == "ÇAMAŞIR MAKİNESİ").ToString();
            label29.Text = db.TBLURUN.Count(x => x.URUNAD == "BULAŞIK MAKİNESİ").ToString();
            label31.Text = db.TBLURUN.Count(x => x.URUNAD == "SU ISITICI").ToString();
            label33.Text = db.TBLURUN.Count(x => x.URUNAD == "LAPTOP").ToString();
            label35.Text = db.MARKAGETIR().FirstOrDefault();

        }
    }
}
