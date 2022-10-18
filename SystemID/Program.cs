using System.IO;
using System.Text;

namespace SystemID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klasor işlemleri için directory sinifi kullanılır
            //1- klasor listesi alamk için
            #region directoryınfo
            foreach (var item in Directory.GetDirectories(@"c:\"))
            {

                Console.WriteLine(item.ToString());
            }
            foreach (var item in Directory.GetFiles(@"c:\edanur"))
            {
                Console.WriteLine(item.ToString());
            }
            DirectoryInfo sonuc = Directory.CreateDirectory(@"c:\edanur\test");
            Console.WriteLine(sonuc.FullName);
            #endregion


            //DriveInfo:
            #region driveınfo
            DriveInfo[] tumsuruculer = DriveInfo.GetDrives();
            foreach (var surucu in tumsuruculer)
            {
                Console.WriteLine(surucu.Name);
                Console.WriteLine(surucu.TotalSize);
                Console.WriteLine(surucu.DriveType);
                Console.WriteLine(surucu.DriveFormat);

            }
            #endregion

            #region File
            //file static nesnedir.
            #region Dosya okuma yazma
            //FileStream
            //FileStream fs = File.Create(@"c:\edanur\deneme.txt");
            //Console.WriteLine(fs.Name); //oluşturulan dosyanın adını verir.
            //byte[] info = new UTF8Encoding(true).GetBytes(@"eçtiğimiz aylarda ikiz çocuklarından birini doğumda kaybeden Cristiano Ronaldo'nun bu olayı aşamadığı belirtildi. Portekizli yıldızın psikoloğu Jordan Peterson, Ronaldo'nun depresyonda olduğunu aktardı.");
            //fs.Write(info, 0, info.Length);
            //fs.Close();

            //silmek için 
            // File.Delete(@"c:\edanur\deneme.txt");

            //var olan dosyayı yazmak için Append metodu kullanılır

            for(int i = 0; i <10; i++)
            {
                File.AppendAllText(@"c:\edanur\deneme.txt", "bu satır sonradan eklenmiştir", Encoding.UTF8);

            }


            #endregion
            #endregion




        }
        public static void DosyaOlusutr()
        {
            
            FileStream fs = File.Create(@"c:\edanur\deneme.txt");
            Console.WriteLine(fs.Name); //oluşturulan dosyanın adını verir.
            byte[] info = new UTF8Encoding(true).GetBytes(@"geçtiğimiz aylarda ikiz çocuklarından birini doğumda kaybeden Cristiano Ronaldo'nun bu olayı aşamadığı belirtildi. Portekizli yıldızın psikoloğu Jordan Peterson, Ronaldo'nun depresyonda olduğunu aktardı.");
            fs.Write(info, 0, info.Length);
            fs.Close();
        }
    }
}