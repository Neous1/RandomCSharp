using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSDNLinkedLIst
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the link list
            string[] words = {"the", "fox", "jumped", "over", "the", "dog"};
            LinkedList<String> sentence = new LinkedList<string>(words);
            Display(sentence, "The linked list values:");
            Console.WriteLine("sentence.Contains('jumped') = {0}", sentence.Contains("jumped"));

            //Add the word "today" to the beginning of hte linked list.
            sentence.AddFirst("today");
            Display(sentence, "Test 1: Add 'today' to beginning of the list:");

            //Move the first node to be the last node.
            LinkedListNode<string> mark1 = sentence.First;
            sentence.RemoveFirst();
            sentence.AddLast(mark1);
            Display(sentence, "Test 2: Move first node to be last node:");

            //Change ghe last node to be the first node.
            sentence.RemoveLast();
            sentence.AddLast("yesterday");
            Display(sentence, "Test 3: Change the last node to 'yesterday':");

            //Move the last node to be the first node.
            mark1 = sentence.Last;
            sentence.RemoveLast();
            sentence.AddFirst(mark1);
            Display(sentence, "Test 4: Move last node to be first node");

            //Indicate, by using parentheisis  the last occurence of 'the'
            sentence.RemoveFirst();
            LinkedListNode<string> current = sentence.FindLast("the");
            IndicateNode(current, "Test 5: Indicate last occurence of 'the': ");

            //Add 'lazy' and 'old' after 'the' (the linklistNode name current).
            Debug.Assert(current != null, "current != null");
            sentence.AddAfter(current, "old");
            sentence.AddAfter(current, "lazy");
            IndicateNode(current, "Test 6: Add 'lazy' and 'old' after 'the':");





        }

        private static void Display(LinkedList<string> words, string test)
        {
            Console.WriteLine(test);
            foreach (string word in words)
            {
                Console.WriteLine(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void IndicateNode(LinkedListNode<string> node, string test)
        {
            Console.WriteLine(test);
            if (node.List == null)
            {
                Console.WriteLine("Node '{0}' is not in the list. \n");
            }

            StringBuilder result = new StringBuilder("(" + node.Value +")");
            LinkedListNode<string> nodeP = node.Previous;

            while (nodeP != null)
            {
                result.Insert(0, nodeP.Value + " ");
                nodeP = nodeP.Previous;
            }

            node = node.Next;
            while (node != null)
            {
                result.Append(" " + node.Value);
                node = node.Next;
            }

            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}
