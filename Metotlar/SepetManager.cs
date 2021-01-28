using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //parametre parantez içine yazılır.
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi : " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string Aciklama, double Fiyat, int StokAdeti)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi : " + urunAdi);
        }
    }
}
