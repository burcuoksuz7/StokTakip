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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities1 db = new DbEntityUrunEntities1();
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLMUSTERI  //sadece istenilen sütunları listeleme işlemi.
                                        select new
                                        {
                                            x.MUSTERIID,
                                            x.MUSTERIAD,
                                            x.MUSTERISOYAD,
                                            x.SEHIR,
                                            x.DURUM                                           
                                        }).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLMUSTERI t = new TBLMUSTERI();
            t.MUSTERIAD = txtad.Text;
            t.MUSTERISOYAD = txtsoyad.Text;
            t.SEHIR = txtsehir.Text;                      
            db.TBLMUSTERI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Müşteri bilgileri sisteme kaydedildi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var musteri = db.TBLMUSTERI.Find(x);
            db.TBLMUSTERI.Remove(musteri);
            db.SaveChanges();
            MessageBox.Show("Müşteri bilgileri silindi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var musteri = db.TBLMUSTERI.Find(x);
            musteri.MUSTERIAD = txtad.Text;
            musteri.MUSTERISOYAD = txtsoyad.Text;
            musteri.SEHIR = txtsehir.Text;            
            db.SaveChanges();
            MessageBox.Show("Müşteri bilgileri güncellendi.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtad.Clear();
            txtsoyad.Clear();
            txtsehir.Clear();
            txtdurum.Clear();            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
           // txtdurum.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }
    }
}
