using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //mobilya
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //kırtasiye
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35};

            //Pascalcase-stack  //camelCase-heap
        
            ProductManager productManager = new ProductManager();

            productManager.Add(product1);

            Console.WriteLine(product1.ProductName);

            //productManager.Topla2(3, 6);
            //int toplamaSonucu = productManager.Topla(3,6);
            //Console.WriteLine(toplamaSonucu*2);
            Console.ReadKey();
        }
    }
}
