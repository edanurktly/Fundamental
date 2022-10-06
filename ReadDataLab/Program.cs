using System.Reflection.Metadata;

namespace ReadDataLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region soru1
            //Ekrandan girilen iki sayinin birbiriyle toplaminin,
            // birbirine olan farkinin birbirine olan kalani nedir 
            #endregion

            #region soru2
            //dışarıdan girilen iki sayinini 10 eksiğinin karesinin 3e bolümünden kalan nedir?
            #endregion

            #region soru3
            //dışarıdan girilen iki sayinin karelerinin toplami ile
            //karelerinin farkinin toplami nedir?
            #endregion

            #region soru4
            //vize notu %30 final notu 570 olan bir sistemde
            //iki vize bir final notlarını sonucunda  geçme kalma durumunu yaziniz
            #endregion

            #region cevaplar

            
            //soru1

            string? giris;
            int sayi1, sayi2;
            Console.WriteLine("Birinci sayiyi giriniz:");
            giris = Console.ReadLine();
            sayi1 = Convert.ToInt32(giris);

            Console.WriteLine("İkinci sayiyi giriniz:");
            giris = Console.ReadLine();
            sayi2 = Convert.ToInt32(giris);
            Console.WriteLine($"{sayi1} + {sayi2} 'nin toplamı {sayi1 + sayi2}");
            Console.WriteLine($"{sayi1} - {sayi2} 'nin birbirine olan farki {sayi1 - sayi2}");
            Console.WriteLine($"{sayi1} / {sayi2} 'nin kalani {sayi1 / sayi2}");


            //soru2
            string? ikincisoru;
            int s1, s2;
            Console.WriteLine("Birinci sayiyi giriniz:");
            ikincisoru = Console.ReadLine();
            s1 = Convert.ToInt32(ikincisoru);
            Console.WriteLine($"{s1} 'in 10 eksiği {s1 - 10}dur");
            Console.WriteLine($"{s1 - 10}'nin karesi  {(s1 - 10) * (s1 - 10)} 'dir.");
            Console.WriteLine($" {(s1 - 10) * (s1 - 10)}'nin 3e bölümü {((s1 - 10) * (s1 - 10) / 3)}");

            Console.WriteLine("İkinci sayiyi giriniz:");
            ikincisoru = Console.ReadLine();
            s2 = Convert.ToInt32(ikincisoru);
            Console.WriteLine($"{s2} 'in 10 eksiği {s2 - 10}dur");
            Console.WriteLine($"{s2 - 10}'nin karesi  {(s2 - 10) * (s2 - 10)} 'dir.");
            Console.WriteLine($" {(s2 - 10) * (s2 - 10)}'nin 3e bölümü {((s2 - 10) * (s2 - 10) / 3)}");


            //soru3
            string? ücüncüsoru;
            int a, b, kare, kare1, toplam;
            Console.WriteLine("birinci sayiyi giriniz:");
            ücüncüsoru = Console.ReadLine();
            a = Convert.ToInt32(ücüncüsoru);
            Console.WriteLine("ikinci sayiyi giriniz:");
            ücüncüsoru = Console.ReadLine();
            b = Convert.ToInt32(ücüncüsoru);



            //soru4
            float vize1, vize2, final, ortalama, sonuc;
            //float bir degiskene manuel deger atilirsa sayinin sonuna f isareti konur

            Console.WriteLine("birinci vizeyi giriniz:");
            vize1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("ikinci vizeyi giriniz:");
            vize2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("final notunuzu giriniz:");
            final= Convert.ToSingle(Console.ReadLine());
            ortalama = (vize1 + vize2) / 2;
            sonuc =( ortalama * 0.3f) + (final * 0.7f);
            Console.WriteLine($"sonuc:{sonuc}");
            #endregion

             
           
        }

    }
    
}
 
