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
    public partial class FrmUrunIslemleri : Form
    {
        public FrmUrunIslemleri()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities1 db = new DbEntityUrunEntities1();

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN  //sadece istenilen sütunları listeleme işlemi.
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.TBLKATEGORI.AD,
                                            x.DURUM
                                        }).ToList();            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = txtad.Text;
            t.MARKA = txtmarka.Text;
            t.STOK = short.Parse(txtstok.Text);
            t.KATEGORI = int.Parse(cmbKategori.SelectedValue.ToString());
            t.FIYAT = decimal.Parse(txtfiyat.Text);
            t.DURUM = true;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün sisteme kaydedildi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var urun = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün bilgileri silindi.");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {           
            int x = Convert.ToInt32(txtid.Text);
            var urun = db.TBLURUN.Find(x);
            urun.URUNAD = txtad.Text;
            urun.STOK = short.Parse(txtstok.Text);
            urun.MARKA = txtmarka.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün bilgileri güncellendi.");

        }

        private void FrmUrunIslemleri_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATEGORI
                               select new
                               {
                                   x.ID,
                                   x.AD
                               }
                               ).ToList();
            cmbKategori.ValueMember = "ID";
            cmbKategori.DisplayMember = "AD";
            cmbKategori.DataSource = kategoriler;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtmarka.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtstok.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtfiyat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtdurum.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            cmbKategori.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtad.Clear();
            txtdurum.Clear();
            txtfiyat.Clear();
            txtmarka.Clear();
            txtstok.Clear();
        }
    }
}
