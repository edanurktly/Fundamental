namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
          While Dongusu kosul dogru oldugu surece calişir
         Eger koşul yanliş ise donguden cikacaktir.

          */

            // Asagidaki while dongusu çalişmaz
            while (false)
            {
                Console.WriteLine("Hello World");
            }

            #region Tek sayi girilence sonlanan döngü

            //int sayi = 0;
            //while (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Sayi Giriniz");
            //    sayi = int.Parse(Console.ReadLine());

            //} 
            #endregion

            #region Sayinin basamaklarini bulan dongu
            //Console.WriteLine("En az iki basamakli bir sayi giriniz:");
            //int girilen = int.Parse(Console.ReadLine());
            //int basamak = 0;

            //while (girilen>0) 
            //{ 
            //    basamak++;
            //    girilen = girilen / 10;
            //}
            //Console.WriteLine($"Girdiginiz sayi {basamak} basamaklidir");
            #endregion


            #region Ekrandan girilen sayi 0 olana kadar girilen sayilarin cift ve tek toplamlarini bulunuz

            //int tektoplam=0, cifttoplam = 0,sayi=0;
            //while (true) 
            //{

            //    Console.WriteLine("Sayi Giriniz");
            //    sayi=int.Parse(Console.ReadLine());
            //    if (sayi % 2 == 0) cifttoplam++;
            //    else tektoplam++;


            //    Console.WriteLine("Cikmak icin f9 'a basiniz ..");
            //    ConsoleKeyInfo key = Console.ReadKey();

            //    if (key.Key == ConsoleKey.F9)
            //    {
            //        break; //Donguyu kirmaya yarar.
            //    }



            //}


            #endregion


            #region While ile sayi tahmin oyunu

            //int tahminhakki = 10, tutulansayi = 1, tahmin = 0,sayac=0;
            //Random rnd = new Random();
            //tutulansayi = rnd.Next(1, 50);
            //1. Yontem
            //while (true)
            //{
            //    Console.WriteLine($"{tahminhakki}. Tahmini Giriniz:");
            //    tahmin = int.Parse(Console.ReadLine());
            //    if(tahmin < tutulansayi && tahminhakki>0) 
            //    {
            //        Console.WriteLine("Buyutun");
            //        tahminhakki--;
            //    }
            //    else if(tahmin > tutulansayi && tahminhakki > 0)
            //    {
            //        Console.WriteLine("Kucultun");
            //        tahminhakki--;
            //    }
            //    else 
            //    {
            //        Console.WriteLine($"Tebrikler {tahminhakki} . denemede buldunuz.");
            //        break;

            //    }
            //}

            //2. Yontem
            //while (tahmin!=tutulansayi)
            //{
            //    sayac++;
            //    Console.WriteLine($"Tahmini Giriniz:");
            //    tahmin = int.Parse(Console.ReadLine());
            //    if (tahmin < tutulansayi )
            //    {
            //        Console.WriteLine("Buyutun");
            //        tahminhakki--;
            //    }
            //    else if (tahmin > tutulansayi )
            //    {
            //        Console.WriteLine("Kucultun");
            //        tahminhakki--;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Tebrikler {sayac} . denemede buldunuz.");
            //        break;

            //    }
            //}



            #endregion

            #region Do-while ile sayi tahmin oyunu
            //int tahminhakki = 10, tutulansayi = 1, tahmin = 0, sayac = 0;
            //Random rnd = new Random();
            //tutulansayi = rnd.Next(1, 50);

            //do
            //{
            //    sayac++;



            //    Console.WriteLine($"{tahminhakki}. Tahmini Giriniz:");
            //    tahmin = int.Parse(Console.ReadLine());
            //    if (tahmin < tutulansayi)
            //    {
            //        Console.WriteLine("Buyutun");
            //        tahminhakki--;
            //    }
            //    else if (tahmin > tutulansayi)
            //    {
            //        Console.WriteLine("Kucultun");
            //        tahminhakki--;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Tebrikler {sayac} . denemede buldunuz.");
            //        break;

            //    }

            //} while (tahmin!=tutulansayi);

            #endregion

            #region For ile sayi tahmin oyunu

            //int tahminhakki = 10, tutulansayi = 1, tahmin = 0, sayac = 0;
            //Random rnd = new Random();
            //tutulansayi = rnd.Next(1, 50);

            //for (int i = 0; i < tahminhakki; i++)
            //{
            //    Console.WriteLine($"{i+1}. Tahmini Giriniz:");
            //    tahmin = int.Parse(Console.ReadLine());
            //    if (tahmin < tutulansayi)
            //    {
            //        Console.WriteLine("Buyutun");

            //    }
            //    else if (tahmin > tutulansayi)
            //    {
            //        Console.WriteLine("Kucultun");

            //    }
            //    else
            //    {
            //        Console.WriteLine($"Tebrikler {i+1} . denemede buldunuz.");
            //        break;

            //    }

            //}


            #endregion

            #region Carpim Tablosu
            /*
             1x1 = 1
             1x2 = 2
             .....
             */
            #endregion

            #region  Fibanocci 
            // Kullanicidan ust sinir alalim.. 
            // Girilen sinira kadar fibanocci sayilarini ekrana yazdirialim
            //1,1,2,3,5,8,13,21,34......


            //Ekrandan Ust Limit Okutuyoruz
            Console.WriteLine("Ust Limiti Giriniz");
            int ustLimit = int.Parse(Console.ReadLine());

            // diziyi tanimliyoruz
            int[] fibonacci = new int[ustLimit];
            fibonacci[0] = 1;
            fibonacci[1] = 1;

            for (int i = 2; i < ustLimit; i++)
            {

                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];


            }
            for (int i = 0; i < fibonacci.Length; i++)
            {


                if (i > 5)
                {
                    Console.WriteLine(fibonacci[i] + "\t" + (fibonacci[i] / Convert.ToSingle(fibonacci[i - 1])));
                }
                else
                {
                    Console.WriteLine(fibonacci[i]);
                }
            }


            #endregion
        }
    }
}