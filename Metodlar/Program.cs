using System.Reflection.Metadata.Ecma335;

namespace Metodlar
{
    internal class Program
    {
        /*
           Metodlar sadece kendi işini yapan subrutin kodlardır.
        1-Tekrarlı kodları engeller
        2-Kod kalabalıklığından kurtarır
        Genel Anlamda Metodlar 2'ye ayrılır.

          -Geriye değer dönmeyen metodlar:
             1-parametre alan metodlar
             2-parametre almayan metodlar
          -geriye bir değer dönen metodlar
             1-parametre alan metodlar
             2-parametre almayan metodlar
         */
        static void Main(string[] args)
        {


            //EkranaYazdir();
            // EkranaMesajYaz("deneme 123");
            //Ekranamesajyaz2("hello mars".10);
            int sonuc = Topla(3, 5,3);
            Console.WriteLine("faktoryel 500:" + faktoryelAl(500));
            Console.WriteLine("mutlak :" + mutlakal(-3));
            Console.WriteLine("us:" + us(2,5));
            Console.WriteLine("toplam:"+sonuc);
            Console.WriteLine("Hello, World!");
        }

        //geriye değer dönmeyen ve parametre almayan metod
        static void EkranaYazdir() 
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        //eriye değer dönmeye , parametre alan metod
        static void EkranaMesajYaz(string mesaj)
        {
            Console.WriteLine(mesaj);
        }

        //geriye değer donen ve birden fazla paramere alan metod
        static int Topla(int a,int b)
        {
            return (a + b);
        }
        static int Topla(int a, int b, int c)
        {
            return (a + b + c);
        }
        ///<summary>
        /// Uc parametre alan metod
        /// </summary>
        /// <param name="a">int tipindedir </param>
        /// <param name="b">int tipindedir </param>
        /// <param name="c">float tipindedir </param>
        /// <returns> int değer geri döner </returns>
        
        static int Topla(int a, int b, float c)
        {
            return (a + b + (int)c);
        }

        //verilen iki string değer birleştirip geri dönen metod
          static string birlestir(string deger1, string deger2)
        {
            return deger1 +" " + deger2;
        }

        //verilen sayinin faktoryelini geri dönen metod
           
          static ulong faktoryelAl(int sayi)
        {
            ulong faktoryel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoryel  *= (ulong)i;
            }
            return faktoryel;
        }
        //verilen sayinin mutlak değerini alan metod
        static int mutlakal(int sayi)
        {
            if (sayi < 0)
            {
                sayi = sayi * (-1);
            }
            return sayi;
        }

        //verilen sayinin ikinci verilen sayiya göre ussunu alan metod
        static int us(int sayi1, int sayi2)
        {
            int sonuc = 1;
            for (int i = 1; i <= sayi2; i++)
            {
                sonuc *= sayi1;
            }
            return sonuc ;

        }

        
        //katsayilari verilen ikinci derece denklemin kodlarını yazdıran metod
         //bkare-4ac (formülü)


        //login metodu  geriye bool deger donecek. username ve password alacak
        //username: admin password:123

        //yeniKodoluştur metodu olacak
        //string yebikodolustur("cari-123")
        //geri donus değeri cari-124

        //verilen string ifadenin sayi olup lmadığını kontrol eden metod
        //eğer sayi iae int'e cevirip donsun
        //ceviremedi ise -1 donsun

        



    }
}