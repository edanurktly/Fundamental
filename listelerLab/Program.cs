using Microsoft.VisualBasic;

namespace ListelerLab
{
    struct Ogrenci
    {
        public string Ad;
        public string Soyad;
        public string TcNo;
        public string Cinsiyet;
        public string DogumTarihi;


    }

    internal class Program
    {



        static void Main(string[] args)
        {
            #region örnek1

          

            /*
             1- Ogrenici Kayit
             2- Ogrenci Listesi
             3- Cikis
            Ogrenci Kayit icin : 
            
            Ad,
            Soyad ,
            TcNo,
            Cinsiyet,
            DogumTarihi 
            
            okutulup listlerde tutacak program
            Kac adet kayit yapilacagi belli degildir.
             */
            string secim = "";
            //List<string> Adlar = new List<string>();
            //List<string> Soyadlar = new List<string>();
            //List<string> TcNolar = new List<string>();
            //List<string> Cinsiyetler = new List<string>();
            //List<string> DogumTarihleri = new List<string>();
            List<Ogrenci> Ogrenciler = new List<Ogrenci>();

            do
            {
                Console.WriteLine("1- Ogrenci Kayit");
                Console.WriteLine("2- Ogrenci Listesi");
                Console.WriteLine("3 - Cikis");
                secim = Console.ReadLine();

                if (secim == "1")
                {
                    //Console.WriteLine("Adiniz Giriniz:");
                    //Adlar.Add(Console.ReadLine());
                    //Console.WriteLine("Soyadiniz Giriniz:");
                    //Soyadlar.Add(Console.ReadLine());
                    //Console.WriteLine("TcNo Giriniz:");
                    //TcNolar.Add(Console.ReadLine());
                    //Console.WriteLine("Cinsiyetinizi Giriniz:");
                    //Cinsiyetler.Add(Console.ReadLine());
                    //Console.WriteLine("Dogum Tarihini Giriniz:");
                    //DogumTarihleri.Add(Console.ReadLine());
                    Ogrenci ogrenci = new Ogrenci();

                    Console.WriteLine("Adiniz Giriniz:");
                    ogrenci.Ad = Console.ReadLine();
                    Console.WriteLine("Soyadiniz Giriniz:");
                    ogrenci.Soyad = Console.ReadLine();
                    Console.WriteLine("TcNo Giriniz:");
                    ogrenci.TcNo = Console.ReadLine();
                    Console.WriteLine("Cinsiyetinizi Giriniz:");
                    ogrenci.Cinsiyet = Console.ReadLine();
                    Console.WriteLine("Dogum Tarihini Giriniz:");
                    ogrenci.DogumTarihi = Console.ReadLine();


                    Ogrenciler.Add(ogrenci);


                }
                else if (secim == "2")
                {
                    //for (int i = 0; i<Adlar.Count; i++)
                    //{
                    //    Console.WriteLine($"{Adlar[i]} {Soyadlar[i]} {TcNolar[i]}  {Cinsiyetler[i]} {DogumTarihleri[i]}" );
                    //}
                    foreach (Ogrenci ogrenci in Ogrenciler)
                    {
                        Console.WriteLine($"{ogrenci.Ad} {ogrenci.Soyad} {ogrenci.TcNo}  {ogrenci.Cinsiyet} {ogrenci.DogumTarihi}");
                    }
                }
            } while (secim != "3");
            #endregion

          
        }
    }
}
