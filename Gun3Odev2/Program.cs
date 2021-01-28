using System;

namespace Gun3Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi2 = 10;

            Console.WriteLine(Mahmut(out int sayi1, sayi2));
            Console.WriteLine(sayi1);

            Console.ReadKey();
        }

        static int Mahmut(out int s1, int s2)
        {
            s1 = 30;
            return s1 + s2;
        }
    }
}
