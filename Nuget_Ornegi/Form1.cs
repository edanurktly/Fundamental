using Bogus;
using Bogus.Extensions.UnitedStates;
using System.Text;

namespace Nuget_Ornegi
{
    struct Kisi
    {
        public string Ad;
        public string Soyad;
        public string Gsm;
        public string Email;
        public string Ulke;
        public string Sehir;
        public DateTime DogumTarihi;
    };


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Kisi> liste = new List<Kisi>();
        const string DosyaYolu = @"c:\Ercan\Kisiler.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            Faker faker = new Faker();
            txtadi.Text = faker.Person.FirstName;
            txtsoyadi.Text = faker.Person.LastName;
            txtgsm.Text = faker.Person.Phone;
            txtemail.Text = faker.Person.Email;
            txtDogumTarihi.Text = faker.Person.DateOfBirth.ToString();

            txtulke.Text = faker.Address.Country();
            txtsehir.Text = faker.Address.City();
            Kisi kisi = new Kisi();
            kisi.Ad = txtadi.Text; ;
            kisi.Soyad = txtsoyadi.Text;
            kisi.Gsm = txtgsm.Text;
            kisi.Email = txtemail.Text;
            kisi.Ulke = txtulke.Text;
            kisi.Sehir = txtsehir.Text;
            kisi.DogumTarihi = Convert.ToDateTime(txtDogumTarihi.Text);

            liste.Add(kisi);

            // Olusan verileri Kayit.txt dosyasina atiniz.
            // 


        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs;
            if (!File.Exists(DosyaYolu))
            {
                fs = File.Create(DosyaYolu);
            }
            else
            {
                fs = File.OpenWrite(DosyaYolu);
            }

            string temp = "";
            int index = 0;
            foreach (Kisi kisi in liste)
            {
                index++;
                temp += index.ToString() + "\t" + kisi.Ad + "\t" + kisi.Soyad + "\t" + kisi.Gsm + "\t" + kisi.Email + "\t" + kisi.Ulke + "\t" + kisi.Sehir + "\t" + kisi.DogumTarihi + "\n";
            }

            byte[] info = new UTF8Encoding(true).GetBytes(temp);
            fs.Write(info, 0, info.Length);
            fs.Close();

        }
    }
}