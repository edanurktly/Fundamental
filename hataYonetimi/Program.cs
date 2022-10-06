namespace hataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
             * İSTİSNAİ TİPLER
             * 1-ÇALIŞMA ZAMANI HATALARI: çoğunlukla kullanıcı kaynaklı hatalarıdır.
             * 2-DERLEME ZAMANI HATALARI: yazılımcının yaptığı hatalardır.
             * 3-MANTIKSAL HATALAR: en zor tespit edilen hata tipidir.
             */

            //breakpoint:programın çalışırken durmasını istediğimiz yer
            //olursa kullandiğimşiz yöntemdir


            //hata yönetimi try catch mekanizması kullanılır
            // try==> deneme
            //catch =>yakalamak 
            int a = 5, b= 0, sonuc = 0;
            try
            {
                sonuc = a / b;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // console.writeLine("sonuc:"+sonuc);
;        }
    }
}