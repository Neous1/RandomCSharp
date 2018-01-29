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
        private Node _first;

        public bool IsEmpty()
        {
            return (_first == null);
        }

        public void InsertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = _first;
            _first = newNode;
        }

        public Node DeleteFirst()
        {
            Node temp = _first;
            _first = _first.next;
            return temp;
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
