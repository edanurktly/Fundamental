using MDIFormlar.Formlar;

namespace AnaForm
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmurunekle1 urunekle=new frmurunekle1();
            urunekle.MdiParent = this;
            urunekle.Show();
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListele urunlistesi = new ();
            urunlistesi.MdiParent = this;
            urunlistesi.Show();
        
         }
    }
}