using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = {2, 3, 1, 5, 2};

            for (var i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[i] is " + a[i]);
                for (var j = 1; j < a.Length;)
                {
                  //  Console.WriteLine("value is : " + a[j]);
                    if (a[i] == a[j])
                    {
                        Console.WriteLine("a[i] is {0} a[j] is {1} index is {2}", a[i], a[j], i);
                    }
                    else
                    {
                        j++;
                    }
                    break;
                }
            }

            Console.ReadLine();
        }


    }
}
