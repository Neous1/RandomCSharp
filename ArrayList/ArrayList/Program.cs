﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList al = new System.Collections.ArrayList();

            Console.WriteLine("Adding some numbers");
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);

            Console.WriteLine("Capacity: {0}", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);

            Console.WriteLine("Content: ");
            foreach (int i in al)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine("Sorted Content: ");
            al.Sort();
            foreach (int i in al)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

    }
}
