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
            int[] a = {2, 3, 1, 2, 5,3};

            int target = 0;
        
            int skip = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0 )
                {
                    Console.WriteLine("negative");
                }
                else
                {
                    target = a[i];
                    a[target] = -a[target];

                }

            }
            
                Console.WriteLine(skip -1);
        }

            
    }

            
}


    

