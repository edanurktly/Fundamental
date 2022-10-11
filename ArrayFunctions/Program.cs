namespace ArrayFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Şu ana kadar gördüğümüz ilkel diziler bize çok esneklik sağlamadı
            //Microsoft mühendislerinin geliştirdiği Array sınıfı diziler yeniden boyutlandırmak 
            //sıralamak,temizlemek için gerekli araçları sunar.

            string[] sehirler = { "ADANA", "ANKARA", "IZMIR", "ISTANBUL", "BURSA", "KOCAELİ", "SAKARYA", "ESKİŞEHİR", "SAMSUN" };
            #region clear
            //1.parametre kaynak dizi
            //2. parametre nereden başlayacağı
            //3.parametre kaç adet sileceği
            //    Array.Clear(sehirler,1,2);
            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}
            //dizini tamamını temizlemek
            #endregion

            #region copy
            /*
              Array.Copy=> bir diziden başka bir diziye eleman kopyalar
             */
            //string[] sehirleryeni = new string[4];
            //Array.Copy(sehirler, sehirleryeni, 4);
            //foreach (var item in sehirleryeni)
            //{
            //    Console.WriteLine(item);
            //}

            //2.kullanım şekli
            //string[] sehirleryeni = new string[4];
            //Array Copy(sehirler,2,sehirleryeni,0,4);
            //foreach (var item in sehirleryeni)
            //{


            //  Console.WriteLine(item);
            //}

            #endregion

            #region IndexOf
            /*
             Dizide aranan elamanın index numarasını dondurur.
             */
            //Console.WriteLine("Sehir Adı Giriniz:");
            //string sehir = Console.ReadLine();
            //int index = Array.IndexOf(sehirler, sehir);
            //Console.WriteLine($"{index} {sehir}");
            #endregion

            #region LastIndexOf
            /*
             Dizide aranan elemanın index numarasını dondurur.
             */
            //Console.WriteLine("SEHİR ADI GİRİNİZ:");
            //string sehir = Console.ReadLine();
            //int index = Array.IndexOf(sehirler, sehir);
            //Console.WriteLine($"{index} {sehir}");
            #endregion

            #region ReSize
            Array.Resize(ref sehirler, 20);
            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region sort
            //Array.Sort(sehirler);
            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Reverse Terse Cevirme
            //Array.Reverse(sehirler);
            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


        }
    }
}