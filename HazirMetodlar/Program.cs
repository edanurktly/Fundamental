namespace HazirMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string metodlar

            string haber = "Ukrayna'yı işgal etmesinin ardından Batı'nın yaptırımlar uyguladığı Rusya, Avrupa'ya doğal gaz akışını kesmiş ve bununun sonucunda Avrupa ülkeleri kışı nasıl geçireceğinin planları yapmaya başlamıştı.";
            string[] kelimeler = haber.Split(' ');

            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
            //cümledeki batı index numarasını nasıl alırız:
             int batıIndex=haber.IndexOf("Batı");
            Console.WriteLine("Batının index numarası:" + batıIndex);
            //substring :belirtilen yerden belirtilen kadar veri çekmeye yarayan metod
            string batı = haber.Substring(batıIndex, 9);
            Console.WriteLine(batı);
            Console.WriteLine("toplam harf sayisi:" + haber.Length);


            //cümle içerisindeki bazı kelimeleri değiştirmek istediğimizde Replace kullanılır.
            //orjinal cumlede değişiklik yapmaz. yapılmış halini size string olarak geri döner

            string yeniCumle = haber.Replace("kesmiş", "******");
            Console.WriteLine(haber);
            Console.WriteLine(yeniCumle);
            #endregion
            Console.WriteLine("toplam kelime sayisi:"+kelimeler.Length);    
        }
    }
}