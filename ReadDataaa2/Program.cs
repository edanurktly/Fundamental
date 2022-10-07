using System.Reflection.Metadata;

namespace ReadDataaa2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ekrandan Veri Okuma



            ////Ekrandan Veri Okuma

            ////Degisken tanimalamalari yapilirken veri tipinin sonuna 
            ////Egerki ? isareti konulursa null deger alabilir demektir.
            //string? giris;
            //int sayi1, sayi2;
            //DateTime trh;

            //Console.WriteLine("Birinci sayiyi giriniz:");
            //giris = Console.ReadLine(); //Ekrandan sayi okutuyoruz
            //sayi1 = Convert.ToInt32(giris);

            //Console.WriteLine("İkinci sayiyi giriniz:");
            //giris = Console.ReadLine(); //Ekrandan sayi okutuyoruz
            //sayi2 = Convert.ToInt32(giris);


            //Console.WriteLine("tarih giriniz:");
            //giris = Console.ReadLine();
            // trh = Convert.ToDateTime(giris);





            //Ekranda göstermek için 1.yol
            //Console.WriteLine("Girilen sayilar {0} VE {1}", sayi1, sayi2);
            ////ekranda göstermke için 2. yol
            //Console.WriteLine($"girilen sayilar {sayi1} ve {sayi2}");
            ////ekranda göstermek için 3.yol
            //Console.WriteLine("girilen sayilar" + sayi1 + " ve " + sayi2);

            //Console.WriteLine("girilen tarih:" +trh);

            double myDouble = 9.78;
            int myInt = (int)myDouble; // Manual casting:double to int

            Console.WriteLine(myDouble); //Outputs 9.78
            Console.WriteLine(myInt); //OutPuts 9
            float myFloat = Convert.ToSingle(myDouble); // float cevirim icin ToSingle() metodu kullanılır.
            myFloat = (float)myDouble;
            byte myByte = (byte)myDouble;
            #endregion


            #region AritmetikIslemler
            /*
               Aritmetik Operatorler

                 dört islem için: +,-,*,/
                 kalan operatoru: %
                  arttirma operatoru:++
                  eksiltme operatoru:--
            */
            int a = 5; int b = 32; int c = 0; // int d = 5;

            Console.WriteLine($"{b} nin {a} bolumunden kalan {b % a}");
            c = a + b; //sonuc:37
            c = 0;
            b++;
            c = a + b; //sonuc: 38
            c = a + b++;
            Console.WriteLine($"a'nin degeri:{a} b'nin degeri{b} sonuc:{c}");
            c = a + b++;
            Console.WriteLine($"a'nin degeri:{a} b'nin degeri{b} sonuc:{c}");
            Console.WriteLine("------------------------");
            c = a + ++b;
            Console.WriteLine($"a'nin degeri:{a} b'nin degeri{b} sonuc:{c}");

            c = ++a + ++b;
            Console.WriteLine($"a'nin degeri:{a} b'nin degeri{b} sonuc:{c}");
            // acik deklerasyon 
            a++; //a=a+1
            b++; //b=b+1
            c = a + b; //

            //Diger arttirma islemi
            a += 1;
            b -= 1;// b=b-1
            a *= 2; //a=a*2;
            Console.WriteLine("A=" + a);
            a *= a;
            Console.WriteLine("A=" + a);
            a *= (a*=a);
            Console.WriteLine("A=" + a);


            #endregion

            Console.WriteLine("cikmak icin enter tusuna basininiz...");
            Console.ReadLine();
        }

    }
}