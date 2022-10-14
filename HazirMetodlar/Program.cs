namespace HazirMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string metodlar

            //string haber = "Ukrayna'yı işgal etmesinin ardından Batı'nın yaptırımlar uyguladığı Rusya, Avrupa'ya doğal gaz akışını kesmiş ve bununun sonucunda Avrupa ülkeleri kışı nasıl geçireceğinin planları yapmaya başlamıştı.";
            //string[] kelimeler = haber.Split(' ');

            //foreach (string kelime in kelimeler)
            //{
            //    Console.WriteLine(kelime);
            //}
            ////cümledeki batı index numarasını nasıl alırız:
            //int batıIndex = haber.IndexOf("Batı");
            //Console.WriteLine("Batının index numarası:" + batıIndex);
            ////substring :belirtilen yerden belirtilen kadar veri çekmeye yarayan metod
            //string batı = haber.Substring(batıIndex, 9);
            //Console.WriteLine(batı);
            //Console.WriteLine("toplam harf sayisi:" + haber.Length);


            ////cümle içerisindeki bazı kelimeleri değiştirmek istediğimizde Replace kullanılır.
            ////orjinal cumlede değişiklik yapmaz. yapılmış halini size string olarak geri döner

            //string yeniCumle = haber.Replace("kesmiş", "******");
            //Console.WriteLine(haber);
            //Console.WriteLine(yeniCumle);

            ////StartWith verilen parametre ile başlayıp başlamadığını kontrol eder.
            //bool lg = yeniCumle.StartsWith("Ak");
            ////EndsWith : verilen parametre ile bitip bitmediğini kontrol eder.
            //lg = yeniCumle.EndsWith("Batı");


            ////Remove:
            //// Console.WriteLine(yeniCumle.Remove(7));
            //Console.WriteLine(yeniCumle.Remove(1, 5));

            ////Insert:
            //Console.WriteLine(yeniCumle.Insert(7, "Ali Veli"));

            ////ToCharArray[]

            //char[] chardizi = yeniCumle.ToCharArray();
            //Console.WriteLine(chardizi);

            ////Trim: Metnin sağ ve solundaki boşlukları atmaya yarar.
            //string cumle = "    Metnin sağ ve solundaki boşlukları atmaya yarar    ";
            //Console.WriteLine(cumle);
            //Console.WriteLine(cumle.Trim());

            ////verilen ifadenin boş olup olmadığını ve aynı zamanda null olup olmadığını kontrol eder
            //if(string.IsNullOrEmpty(cumle))
            //{

            //}
            //Console.WriteLine("toplam kelime sayisi:"+kelimeler.Length);
            #endregion

            #region Math
            //Console.WriteLine("pi:" + Math.PI);
            //Console.WriteLine("tahu:"+Math.Tau);
            //Console.WriteLine("E:"+Math.E);

            ////CEİLLİNG => vERİLEN ONDALIKLI SAYİYİBİR ÜSTE YUVARLAR
            //Console.WriteLine(Math.Ceiling(10.2));

            ////floor=> verilen ondalıklı sayıyı bir alta yuvarllar
            //Console.WriteLine(Math.Ceiling(10.2));

            ////Round: verilen ondalıklı sayıyı yarıdan fazlasını bir uste yuvarlar, yarıdan azını bir alta yuvarlar.
            //Console.WriteLine("*****Round*****");
            //Console.WriteLine(Math.Round(10.4));
            //Console.WriteLine(Math.Round(10.6));
            //Console.WriteLine(Math.Round(10.5));
            //Console.WriteLine(Math.Round(11.5));

            //Console.WriteLine("*******************");

            //Console.WriteLine("25'in kare koku:" + Math.Sqrt(25));

            ////bir sayinin negatif,pozitif ve  olma durumunu sağlayan fonksiyon nedir?
            //// Eğer sayi negatif ise -1 , pozitif ise 1 0 ise doner.
            //Console.WriteLine("******** Sign Metodu ***********");

            //Console.WriteLine(Math.Sign(-20));
            //Console.WriteLine(Math.Sign(20));
            //Console.WriteLine("*********KUVVET ALMA: POWER");
            //Console.WriteLine(Math.Pow(2, 3)); //8 verecektir.

            //Console.WriteLine("*********Truncate******");
            ////sayinin tam kısmını verir.ondalıklı kısmını atar.

            //Console.WriteLine(Math.Truncate(12.7));

            //Console.WriteLine("*******mutlak değer :abs");
            ////sayinin mutlak değerini verir.


            #endregion

            #region DateTime Metodlari
            //bulunduğunuz ani veren metod
            Console.WriteLine(DateTime.Now);

            //Bulunduğunuz ani veren metod 0. meridyenin zamanın verir
            Console.WriteLine(DateTime.UtcNow);

            // artik yil kontrolu 
            Console.WriteLine(DateTime.IsLeapYear(2000));

            //haftanın günü 
            Console.WriteLine(DateTime.Now.DayOfWeek);

            //yilin kaçıncı günü
            Console.WriteLine(DateTime.Now.DayOfYear);

            //yeni bir tarih oluşturmak için
            DateTime yeniTarih = new DateTime(2000, 1, 1);
            Console.WriteLine(yeniTarih);

            //iki tarih arasındaki zaman 04.04.2000

            DateTime dogumGunu = new DateTime(2000, 4, 4);

            TimeSpan timeSpan=DateTime.Now - dogumGunu;
            Console.WriteLine($"Ertuğrul { timeSpan.Days} gundur hayatta {timeSpan.Hours} saat{timeSpan.TotalSeconds}saniyedir.");


            #endregion
        }
    }
}