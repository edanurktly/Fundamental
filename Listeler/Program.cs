namespace Listeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List <> icerisine (<T>ype) verilen tipe burunerek o tiple ilgili ArrayList özelliğine kavuşur


            List<string> sehirler = new List<string>();
            sehirler.Add("adana");
            sehirler.Add("ankara");
            sehirler.Add("15");
            sehirler.Add(20.ToString());

        }
    }
}