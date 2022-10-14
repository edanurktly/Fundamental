namespace Metod_OutRef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
             bir metod içerisinde dýþarýya birden fazla deðer götürmek istediðimizde
             return anahtar kelimesi size yetmeyecektir.
             bunu aþmanýn yolu out anahtar kelimesidir.
             out anahtar kelimesi metoda gönderdiðimiz deðiþkenin referansýný gönderiri.
             
             Out ile iþaretlenen deðiþkene metod içerisinde deðer atanmasý zorunludur.
             
            */

            double sonuc = 0;
            geriyeDegerDonduren(5, out sonuc);
           // MessageBox.Show(kare.ToString());
           listBox1.Items.Add("5'in karesi:"+ sonuc);
           // bool oldumu = SayiyaCevir("45" , out sonuc);
            listBox1.Items.Add($" '45' double karsili {sonuc}");

            //ornek3
            int sayi1 = 50, sayi2 = 5, toplam = 0, fark = 0, carpim = 0, bolum = 0;
            Hesapla(sayi1, sayi2, out toplam, out fark, out carpim, out bolum);
        }
        #region Out Ornek 1
        void geriyeDegerDonduren(int sayi, out double firlatilacakSayi)
        {
            firlatilacakSayi = sayi * sayi;
        }
        #endregion

        #region Out Ornek 2
        public bool SayiyaCevir(int sayi, out double firlatilacaksayi)
        {
            try
            {
                firlatilacaksayi = Convert.ToDouble(sayi);
                return true;
            }
            catch 
            {
                firlatilacaksayi = -1;
                return false;
            }
        }
        #endregion

        #region Out Ornek 3
        public void Hesapla (int sayi1, int sayi2, out int toplam, out int fark, out int carpim, out int bolum)
        {
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpim = sayi1 * sayi2;
            if (sayi1 != 0 && sayi2 != 0)
                bolum = sayi1 / sayi2;
            else bolum = 0;
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            /**/

            int[] dizi = { 1, 2, 3, 4 };
            ArrayResize(ref dizi, 10);
            foreach (var item in dizi)
            {
                listBox1.Items.Add(item);
            }
        }


        void ArrayResize(ref int[] sayilar, int yeniBoyut)
        {
            int[] yeniDizi = new int[yeniBoyut];
            try
            {
                sayilar.CopyTo(yeniDizi, 0);
            }
            catch(Exception)
            {
                throw new Exception("Daha kucuk bir dizi olusturulamaz");
            }
            sayilar = yeniDizi; // Referans atamasi yapar
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}