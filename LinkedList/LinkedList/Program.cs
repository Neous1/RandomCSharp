using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

 
    //create node class
    public class Node
    {
        public int data;
        public Node next;

        public void displayNOde()
        {
            Console.WriteLine("<" + data + ">");
        }
    }
}
