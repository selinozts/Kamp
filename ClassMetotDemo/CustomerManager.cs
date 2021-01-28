using System;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void List(params Customer[] customers)
        {
            Console.WriteLine("-------Customer List--------");

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Customer Add: " + customer.Id + " "+ customer.Name+" " + customer.Surname + " " + customer.Age + " " + customer.Occupation + " " + customer.Salary);
            }
        }
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.Name} {customer.Surname} added to database!.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine($"{customer.Name} {customer.Surname} deleted from database!");
        }
    
        public void Update(Customer customer)
        {
            Console.WriteLine($"{customer.Occupation} {customer.Salary} updated!");
        }
    }
}