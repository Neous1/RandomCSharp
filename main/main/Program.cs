﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop ***************************
            int number = 0;
            while(number < 5)
            {
                Console.WriteLine(number);
                number += 1;
            }
            Console.ReadLine();

            //do While loop ******************************
            do
            {
                Console.WriteLine(number);
                number += 1;

            } while (number < 10);


            // For Loop ************************************
            int num = 5;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);
                               
            }
            Console.ReadLine();

            // Foreach loop ***********************************
            var people = new List<string>();
            people.Add("yvon doe");

            string[] folks = new string[3] { "john doe", "jane doe", "baby doe" };

            people.AddRange(folks);

            foreach (var item in people)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            //some comments here to test

            int x = 1;
            int y = 2;
            var result = AddNumbers(y, x);
        }


        public static int AddNumbers(int number2, int number1)
        {
            var result = number1 + number2;

            Console.WriteLine(result);
            return 0;
        }

    }

}
