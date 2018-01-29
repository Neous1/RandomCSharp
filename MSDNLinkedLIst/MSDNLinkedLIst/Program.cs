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

            //Add the world "today" to the beginning of hte linked list.
            sentence.AddFirst("today");
            Display(sentence, "Test 1: Add 'today' to beginning of the list:");

            
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
