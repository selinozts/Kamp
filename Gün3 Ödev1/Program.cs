using System;

namespace Gün3_Ödev1
{
    class Program
    {
        //aynı metotu tekrar tekrar kullanıp tek merkezde toplamak
        //
        static void Main(string[] args)
        {
            //int x = 5;
            //int y = 10;



            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadKey();
        }

        static int Add(ref int s1, int s2)
        {
            s1 += 10;
            return s1 + s2;

        }

        static int Multiply(int number1, int number2)
        {

            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {

            return number1 * number2 * number3;
        }

        static int Add4(int number, params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}