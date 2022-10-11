namespace diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Array => Dizi
           Birden fazla ayni tipten veriyi bir arada tutmamizi saglayan nesnelerdir
           Cok karsilasilan hata:  Index was outside the bounds of the array 
           Eger bu hatayi alirsaniz bilinki dizinin boyutunu asacak bir islem yapmaktasiniz.

            */

            // 1.Tanimlama [] operatoru ile tanimlanir
            // VeriTipi[] diziAdi = new VeriTip[ElemanSayisi]
            //int[] sayilar = new int[3];
            //sayilar[0] = 1;
            //sayilar[1] = 2;
            //sayilar[2] = 3;
            //Burasi hata verecektir.
            //Verdigi hata :Index was outside the bounds of the array 
            //sayilar[3] = 4;
            //sayilar[4] = 5;

            //2. Tanimlama . Object Initilaise
            //string[] sehirler = new string[3] {"Adana","Ankara","Istanbul" };

            // 3. Tanimlama Yontemi 
            //string[] sehirler2 = { "Adana", "Ankara", "Istanbul" };

            //char[] alfabe = { 'a', 'b', 'c' };


            //double[] alfabe2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10};

            // Dizinin eleman sayisi .Length propert'si icerisindedir
            //Console.WriteLine("Dizi Boyutunu Giriniz:");
            //int boyut = Convert.ToInt32(Console.ReadLine());
            //int[] sayilar = new int[boyut];

            //int index = 0;
            //Random rand = new Random();
            #region While Dongusu


            ////While Dongusu 
            //while (index < boyut) 
            //{
            //    sayilar[index] = rand.Next(5,500);

            //    index++;
            //}
            #endregion

            #region Do-While Dongusu
            //index = 0;
            //do
            //{
            //    Console.WriteLine(sayilar[index]);
            //    index++; 
            //} while (index<boyut); 
            #endregion

            #region For Dongusu

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //string isim = "Ali Veli";
            //for (int i = 0; i < isim.Length; i++)
            //{
            //    Console.WriteLine(isim[i]);
            //} 
            #endregion


            #region Rastgele olusturulan 50 elemanli bir dizinin Tek ve cift sayilarin miktari

            //int[] sayilar2 = new int[50];
            //int cift=0, tek=0;

            //for (int i = 0; i < sayilar2.Length; i++)
            //{
            //    sayilar2[i] = rand.Next(1, 100);

            //}

            //for (int i = 0; i < sayilar2.Length; i++)
            //{
            //    if (sayilar2[i] % 2 == 0)
            //    {
            //        cift++;
            //    }
            //    else
            //    {
            //        tek++;
            //    }
            //}

            //Console.WriteLine("-------------------- Dizi Dokumu----------------");
            //for (int i = 0; i < sayilar2.Length; i++)
            //{
            //    Console.WriteLine(sayilar2[i]);
            //}
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Dizideki Tek eleman sayisi:"+tek);
            //Console.WriteLine("Dizideki Cift eleman sayisi:" + cift);


            #endregion

            #region Ekrandan okutulan sayini faktoryeli ni bulun

            Console.WriteLine("Sayi Giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sonuc = 1;
            for (int i = sayi; i > 1; i--)
            {
                sonuc *= i;
            }
            Console.WriteLine($"Girilen {sayi} nin faktoryeli {sonuc} dir");
            #endregion
        }
    }
}