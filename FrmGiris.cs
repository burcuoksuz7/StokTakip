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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbEntityUrunEntities1 db = new DbEntityUrunEntities1();
            var sorgu = from x in db.TBLADMIN where x.KULLANICI==textBox1.Text && x.SIFRE == textBox2.Text select x;
            if (sorgu.Any()) //eğer sorgu bir şey döndürüyorsa
            {
                FrmAnaform fr = new FrmAnaform();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı !", "Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
