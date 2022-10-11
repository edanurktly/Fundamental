namespace listelerLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1-öğrenci kayıt
             2- öğrenci listesi
                3-cikiş

                öğrenci kayıt için: ad,soyad,tcno,cinsiyet,doğumtarihi okutulup listelerde tutacak program
                kaç adet kayıt yapılacağı belli değildir.
            */
            Console.WriteLine("1-Ogrenci Kayit");
            Console.WriteLine("2-ogrenci listesi");
            Console.WriteLine("3 -cikis");
            string secim =Console.ReadLine();

            switch(secim)
            {
                case "1":
                    {
                        Console.WriteLine("Adinizi Giriniz:");

                    }
                    break;
                case "2":
                    break;
                case "3":
                    break;
                default:
                    break;

            }
        }
    }
}