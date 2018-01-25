using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueClass
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

            Queue<string> numbers = new Queue<string>();
            //add these strings to the queue.
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            //A queue can be enumaretad without disturbing its content
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nDequeing '{0}'", numbers.Dequeue());
            Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());
            Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());

            //Create a copy of hte queue, using the ToArray method and 
            //Consructory that accepts and IEnumerable<T>.

            Queue<string> queueCopy = new Queue<string>(numbers.ToArray());
            Console.WriteLine("\nContents of the first copy");
            foreach (string number in queueCopy)
            {
                Console.WriteLine(number);
            }
            //Create an arry twice the size of hte queue and copy
            //hte elements of hte queeue, starting at the middle of hte 
            //array.

            string[] array2 = new string[numbers.Count * 2];
            numbers.CopyTo(array2, numbers.Count);

            /*Create a second queue, using the constructor that accepts and 
             * IEnuerable(Of T)             
             */
             Queue<string> queueCopy2 = new Queue<string>(array2);
            Console.WriteLine("\nContents of the second copy , with duplicates and nulls:");
            foreach (string number in queueCopy2)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nqueueCopy.Contains(\"four\")={0}", queueCopy.Contains("four"));
            Console.WriteLine("\nqueueCopy.Clear()");
            queueCopy.Clear();
            Console.WriteLine("\nqueueCopy.Count = {0}", queueCopy.Count);
        }
    }
}
