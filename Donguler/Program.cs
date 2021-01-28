using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kursu", "Programlamaya Başlangıç Kursu", "Python", "Java", "Android"};

            //genel kullanım
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
              
            }
            Console.WriteLine("for bitti");

            // dizileri kolay dolaşmak için
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.ReadKey();
        }
    }
}
