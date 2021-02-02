using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        { 
            //yorum satırı yapmak içim ctrl+k+c c=comment
           //string[] isimler = new string[] {"Engin","Murat", "Kerem","Halil" };
           // Console.WriteLine(isimler[0]);
           // Console.WriteLine(isimler[1]);
           // Console.WriteLine(isimler[2]);
           // Console.WriteLine(isimler[3]);
           // isimler[4] = "İlker";
           // Console.WriteLine(isimler[4]);
           // //yeni dizide 0.kısım boş o yüzden boş döndü.
           // Console.WriteLine(isimler[0]);
           //yorum satırından geri almak istersekte ctrl+k+u u=uncomment
            List<string> isimler2 = new List<string> {"Engin", "Murat",
            "Kerem", "Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


            Console.ReadKey();
        }

    }
}
