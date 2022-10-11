using System.Collections;
namespace ArrayListOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList object turundan deger kabul ettiği için 
            //içerisine herhangi bir şey atabilirsiniz

            ArrayList yenidizi = new ArrayList();
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            yenidizi.Add(15);
            yenidizi.Add("ali");
            yenidizi.Add(DateTime.Now);
            yenidizi.Add(sayilar);
            yenidizi.Add(true);
            //ArrayList içerisinden eleman okumak için

            // foreach (var item in yenidizi)
            //{
            //    Console.WriteLine(item);    
            //}
            //dizi boyutu

            Console.WriteLine(yenidizi.Count);

            //araya eleman eklemek için Insert metodu kullanılır
              yenidizi.Insert(2,"veli");
            //foreach(var item in yenidizi)
            //{
            //  console.writeLine(item);
            //}

            //diziden eleman silmek için remove kullanılır
            //index numarsına göre silmek ister isek RemoveAt kullanılır.
            //yenidizi.Remove("veli");
            //yenidizi.RemoveAt(2);
            //foreach (var item in yenidizi)
            //{
            //    Console.WriteLine(item);
            //}

            //sıralama için sort kullanılır .ancak problemlidir.
            //
            //yenidiz.sort();
            foreach (var item in yenidizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}