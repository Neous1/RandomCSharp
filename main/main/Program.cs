using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while(number < 5)
            {
                Console.WriteLine(number);
                number += 1;
            }
            Console.ReadLine();
            do
            {
                Console.WriteLine(number);
                number += 1;

            } while (number < 10);


            int num = 5;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);

                Console.ReadLine();
            }
        }


    }
}
