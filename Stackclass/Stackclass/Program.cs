﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackclass
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Queue q = new Queue();

           q.Enqueue('A');
           q.Enqueue('M');
           q.Enqueue('G');
           q.Enqueue('W');

           Console.WriteLine("Current queue:");
           foreach (char c in q)
           {
           }

           Console.WriteLine();
           q.Enqueue('V');
           q.Enqueue('H');
           Console.WriteLine("Current queue: ");
           foreach (char c in q) Console.Write(c + " ");
           Console.WriteLine();
           Console.WriteLine("Removing some values ");
           char ch = (char)q.Dequeue();
           Console.WriteLine("The removed value: {0}", ch);
           ch = (char)q.Dequeue();
           Console.WriteLine("The removed value: {0}", ch);

           Console.ReadKey();*/

            Stack st = new Stack();

            st.Push('A');
            st.Push('M');
            st.Push('G');
            st.Push('w');

            Console.WriteLine("Current Stack : ");
            foreach (char c in st)
            {
                Console.WriteLine(c + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Removing values ");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.WriteLine(c + " ");
            }
        }
    }
}

