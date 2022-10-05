namespace firstConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            //short -32,768 to 32,767
            Console.WriteLine("Short Max:"+short.MaxValue);
            Console.WriteLine("Short Min:"+short.MinValue);
            //ushort 0 to 65,535
            Console.WriteLine("Ushort Max:" + ushort.MaxValue);
            Console.WriteLine("Ushort Min:" + ushort.MinValue);
            // int -2,147,483,648 to 2,147,483,647
            Console.WriteLine("int Max:" +int.MaxValue);
            Console.WriteLine("int Min:" + int.MinValue);
            //uint 0 to 4,294,967,295 
            Console.WriteLine("uint Max:" + uint.MaxValue);
            Console.WriteLine("uint Min:" + uint.MinValue);
            //long -9,223,372,036,854,775,808 to 9,223,372,372,036
            Console.WriteLine("long Max:" + long.MaxValue);
            Console.WriteLine("long Min:" + long.MinValue);
            //ulong 0 to 18,446,774,073,709,551,615
            Console.WriteLine("ulong Max:" + ulong.MaxValue);
            Console.WriteLine("ulong Min:" + ulong.MinValue);



            //floating-point numeric  types
            //float
            Console.WriteLine("float Max:" + float.MaxValue);
            Console.WriteLine("float Min:" + float.MinValue);

            //double 5.0 x10-28 to 7.228 x 1028
            Console.WriteLine("decimal max:" + decimal.MaxValue);
            Console.WriteLine("decimal min:" + decimal.MinValue);

        }
    }
}