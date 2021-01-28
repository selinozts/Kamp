using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Çağdaş";
            customer1.Surname = "Öz";
            customer1.Age = 25;
            customer1.Occupation = "Doctor";
            customer1.Salary = 15000;


            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Ece";
            customer2.Surname = "Mert";
            customer2.Age = 42;
            customer2.Occupation = "Web Designer";
            customer2.Salary = 8000;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Kağan";
            customer3.Surname = "Kaya";
            customer3.Age = 36;
            customer3.Occupation = "Back-end Developer";
            customer3.Salary = 13000;

        

            CustomerManager manager = new CustomerManager();
            manager.Add(customer3);

            manager.List(customer1, customer2, customer3);

            manager.Delete(customer2);
            manager.Update(customer3);


            Console.ReadKey();
        }
    }
}
