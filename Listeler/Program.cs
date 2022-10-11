using System.Security.Cryptography.X509Certificates;

namespace Listeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List <> icerisine (<T>ype) verilen tipe burunerek o tiple ilgili ArrayList özelliğine kavuşur

            Random random = new Random();
            List<string> sehirler = new List<string>();
            List<int> sayilar = new List<int>();
            sehirler.Add("adana");
            sehirler.Add("ankara");

            if(sehirler.Contains("Adana"))
            {
                Console.WriteLine("Adana Listede mevcut");
            }



            int a = 0;
            for (int i = 0; i < 100; i++)
            {
                sayilar.Add(random.Next(1,100));
                if (i == 32)
                    a = 1;
            }

            /*
             sort işlemi
             */
            sehirler.Sort();
            sayilar.Sort();
            sayilar.ForEach (x => Console.WriteLine(x));

            //random atılan sayıları sadece birkez gösterme
            int gelensayi = 0;
            for (int i = 0; i < 100; i++)
            { 
              gelensayi=random.Next(1,100);
                while(!sayilar.Contains(gelensayi))
                {
                    sayilar.Add(gelensayi);
                }
                sayilar.Add(random.Next(1, 1000));

            }

           
        }
    }
}
