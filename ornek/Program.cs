namespace ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Örnek2
            //kullaıcıdan istenecek belirsiz miktarda sayi içerisinde
            //1-en büyük sayiyi
            //2-en küçük sayiyi
            //3-toplamda kaç adet sayi girdiğiniz
            //4-minimum 2 adet sayi girmek zorunda
            //5-kullanici end/exit yazdığı zaman sayi girişi durdurulacak
            //6-dizideki yilarin 3 ve 5e bölümünden kalanların listesini de bastirin.
            //7-dizideki asal ve mükemmel sayiları listeleyiniz
            string okutulandeger = "";

            List<int> sayilar = new List<int>();
            int sayi = 0, sayac = 0, buyuk = 0, kucuk = 0, kontrol = 0;
             
            do
            {
                Console.WriteLine("sayi giriniz:");
                okutulandeger = Console.ReadLine();

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                        kontrol++;
                }

                if (kontrol != 0)
                    Console.WriteLine("Girdiğiniz sayı asal değildir.");
                else
                    Console.WriteLine("Girdiğiniz sayı asaldır.");
                Console.ReadKey();

                int toplam = 0;
                for (int i = 1; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        toplam = toplam + i;
                    }
                }
                if (toplam == sayi)
                {
                    Console.WriteLine(sayi + "sayı Mükemmel Sayıdır");
                }
                else
                {
                    Console.WriteLine(sayi + "sayı Mükemmel Sayı Değildir");
                }
                Console.ReadLine();



                if (okutulandeger.ToUpper() == "Exit" || okutulandeger.ToUpper() == "END")
                {
                    if (sayac > 2)
                        break;
                    else
                        Console.WriteLine("En az iki sayi girmeniz gerekmektedir");
                }
                else
                {
                    try
                    {
                        sayi = Convert.ToInt32(okutulandeger);
                        sayilar.Add(sayi);
                        sayac++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Sayisal deger giriniz");
                    }
                }

            } while (true);
            

            #endregion
        }
    }
}

 




