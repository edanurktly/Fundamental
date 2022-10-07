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

            #region Finnaly ile kullanimi
            try
            {
             
                //buraya mutlaka girer
            }
            catch(Exception ex)
            {
               //sadece hata olduğunda girer
            }
            finally
            {
                //hata olsun olmasın mutlaka buraya da girer.
            }


            #endregion


            #region birden fazla exception ile yakalama
            try
            {
                Console.WriteLine("bir sayi giriniz:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("İKİNCİ SAYİ GİRİNİZ:");
                b = Convert.ToInt32(Console.ReadLine());
                sonuc = a / b;

            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                throw;
            }
            #endregion
// console.writeLine("sonuc:"+sonuc);
;
        }
    }
}