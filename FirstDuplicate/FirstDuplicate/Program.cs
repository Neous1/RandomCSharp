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
            int[] a = {2, 3, 4, 3, 2, 1};

            int curPos;
            int prevPos;
            int curDup;
            int prevDup;



            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 1; j < a.Length; j++)
                {
                    if (a[i] == a[j] && (i != j))
                    {
                        Console.WriteLine("the values for i is {0} and j is {1}", a[i], a[j]);
                        Console.WriteLine("the index for i is {0} and j is {1}", i , j);
                        Console.WriteLine(a[j]);
                        Console.WriteLine();
                        curDup = a[j];
                        curPos = j;

                    }
                    

                    
                }
            }

           

            Console.ReadLine();
        }


    }
}
