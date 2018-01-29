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

    public class SinglyLinkedList
    {
        private Node first;

        public bool isEmpty()
        {
            return (first == null);
        }

        public void insertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
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
