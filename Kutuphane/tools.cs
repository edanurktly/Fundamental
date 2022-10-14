using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public static class tools
    {
       public  static int us(int sayi1, int sayi2)
        {
            int sonuc = 1;
            for (int i = 1; i <= sayi2; i++)
            {
                sonuc *= sayi1;
            }
            return sonuc;

        }
    }
}
