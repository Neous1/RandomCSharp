using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Dictionary
{
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; } 

    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            var customer2 = new Customer()
            {
                ID = 110,
                Name = "Pam",
                Salary = 6500
            };

            var customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 3500
            };

            //create a customer dictionary of key int and value customer
            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            //add items to dictonary
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer3);
            dictionaryCustomers.Add(customer3.ID, customer3);

            //retrive data from dictionary
            var customer119 =  dictionaryCustomers[119];
            //Console.WriteLine("ID = {0}, Name = {1}, Salary ={2}",customer119.ID, customer119.Name, customer119.Salary);


            foreach(var customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("Key = {0}", customerKeyValuePair.Key);
                var cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}" , cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("----------------------------------------------------------------");

            }
        }
    }
}
