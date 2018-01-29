using System;
using System.Collections.Generic;
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
    }
}
