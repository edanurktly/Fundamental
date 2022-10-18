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
    public partial class frmurunekle1 : Form
    {
        public frmurunekle1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Urun urun = new Urun();
            urun.urunAdi = txturun.Text;
            urun.Barkod=txtbarkod.Text;
            urun.UrunFiyat = (int)nmrfiyat.Value;

            Db_context.Urunler.Add(urun);

            DialogResult dialog = MessageBox.Show("urun eklendi.Yenisini eklemek istermisiniz ?", "Dikkat",MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                txturun.Text = "";
                txtbarkod.Text = "";
                nmrfiyat.Value = 0;
            }
            else
            {
                this.Close();
            }
        }
    }
}
