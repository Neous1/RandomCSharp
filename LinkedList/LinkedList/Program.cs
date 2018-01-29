﻿using System;
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
            SinglyLinkedList myList = new SinglyLinkedList();
            myList.InsertFirst(100);
            myList.InsertFirst(50);
            myList.InsertFirst(99);
            myList.InsertFirst(88);
            myList.insertLast(999000);
            myList.displayList();
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

        public void displayList()
        {
            Console.WriteLine("LIst(first -- last)");
            Node current = _first;
            while (current != null)
            {
                current.displayNode();
                current = current.next;
            }
            Console.WriteLine();
        }

        public void insertLast(int data
            )
        {
            Node current = _first;
            while (current.next != null)
            {
                current = current.next;
            }

            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }

    }
    //create node class
    public class Node
    {
        public int data;
        public Node next;

        public void displayNode()
        {
            Console.WriteLine("<" + data + ">");
        }
    }
}
