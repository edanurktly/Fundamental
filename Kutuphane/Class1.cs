namespace Kutuphane
{
    public class Class1
    {
       public static ulong faktoryelAl(int sayi)
        {
            ulong faktoryel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoryel *= (ulong)i;
            }
            return faktoryel;
        }

       public  static string CreateNewCode(string code)
        {
            string number = "";
            foreach (char item in code)
            {
                if (char.IsDigit(item))
                    number += item;
                else
                    number = "";
            }
            if (number == "")
            {
                number = "1";
            }
            else
            {
                number = (int.Parse(number) + 1).ToString();
            }
            var newNumber = number;

            //var newNumber = number == "" ? "1" : (int.Parse(number) + 1).ToString();

            //gelen kod ile oluşturulacak kodun farkını buluyoruz
            var fark = code.Length - (newNumber.Length - (newNumber.Length - number.Length));
            //cari-9999 => cari -10000

            //mesela cari -9999 ise yeni eklnen cari 10000 olacaktır.
            //bu durumda fark 0 dan kucuk olacaktır

            if (fark < 0)
                fark = 0;
            var newCode = code.Substring(0, fark);
            newCode += newCode;

            return newCode;

        }
    }
}