using System;
using System.Collections.Generic;
using System.Text;
//ürün ile ilgili operasyonları içerir(ekle,sil vs.)
namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        //void-git ekle,sil,güncelle(emir halinde çağırma)
        public void Add (Product product)
        {
            Console.WriteLine(product.ProductName+" eklendi.");
        }
      public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+" güncellendi.");
        }
        //geri dönüş kolay, programın akışında bana o değer lazım
        //public int Topla(int sayi1,int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        //geri dönüş sıkıntılı, git-yap-bitir, dönüşe ihtiyaç var.
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1+sayi2);  
        //}
    }
}
