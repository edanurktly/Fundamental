using MDIFormlar.DbContect;
using MDIFormlar.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIFormlar.Formlar
{
    public partial class frmListele : Form
    {
        public frmListele()
        {
            InitializeComponent();
        }

        private void lsturunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmListele_Load(object sender, EventArgs e)
        {
            UrunleriYukle();

        }

        private void UrunleriYukle()
        {
            lsturunler.Items.Clear();
            foreach(Urun urun in Db_context.Urunler)
            {
                string[] gosterilecekUrunler =
                {
                    urun.urunAdi,
                    urun.Barkod,
                    urun.UrunFiyat.ToString()+" TL"
                };
                ListViewItem satir = new ListViewItem(gosterilecekUrunler);
               //ListViewItem property'sinden olan Tag propuna kendisi ekleniyor.
                satir.Tag = urun;
                lsturunler.Items.Add(satir);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmurunekle1 urunekle = new frmurunekle1();
            urunekle.MdiParent = this.MdiParent;
            urunekle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunleriYukle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(lsturunler.SelectedIndices.Count==0)
            {
                MessageBox.Show("önce silinecek kayıt seçiniz");
                return;
            }
            ListViewItem secilmis = lsturunler.SelectedItems[0];
            Urun urun = (Urun)secilmis.Tag;
            DialogResult result = MessageBox.Show(urun.urunAdi + "  adındaki urun siliecektir Eminmisiniz?", "dikkat",
                                               MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Db_context.Urunler.Remove(urun);
                UrunleriYukle();
            }
            else
            {
                return;
            }

        }

        private void lsturunler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lsturunler.SelectedIndices.Count==0)
            {
                MessageBox.Show("güncelleme için ürün seçmek gerekiyor");
            }
            else
            {
                ListViewItem secilen = lsturunler.SelectedItems[0];
                Urun urun=(Urun)secilen.Tag;
                frmUrunGuncelleme urunGuncelleme = new frmUrunGuncelleme(urun);
                urunGuncelleme.MdiParent = this.MdiParent;
                urunGuncelleme.Show();
            }

            //frmUrunGuncelleme urunGuncelleme=new frmUrunGuncelle();
        }
    }
}

