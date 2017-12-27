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



        }
    }
}
