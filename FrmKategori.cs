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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities1 db = new DbEntityUrunEntities1();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLKATEGORI  //sadece istenilen sütunları listeleme işlemi.
                                        select new
                                        {
                                            x.ID,
                                            x.AD                                          
                                        }).ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLKATEGORI t = new TBLKATEGORI();  //tablodan üretilen nesne ile tabloya ulaşacağız
            t.AD = textBox2.Text;
            db.TBLKATEGORI.Add(t);   //t'den gelen değerleri ekle.
            db.SaveChanges();      //sqldeki executeNonQuery
            MessageBox.Show("Kategori eklendi.");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);   //kategori id sqlde int olarak tanımlı olduğu için int tanımladık.
            var ktgr = db.TBLKATEGORI.Find(x);
            db.TBLKATEGORI.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori silindi.");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);  
            var ktgr = db.TBLKATEGORI.Find(x);
            ktgr.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi gerçekleşti.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
