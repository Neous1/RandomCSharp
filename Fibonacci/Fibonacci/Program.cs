using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            FindFib(9);
        }

        public static int FindFib(int len)

        {
            
            int temp0 = 0, temp1 = 1, res = 0; 

            Console.Write("{0} {1}",temp0, temp1);



            for (int i = 2; i < len; i++)

            {
                res = temp0 + temp1;

                Console.Write(" {0}", res);
                
                //shift indeces forward to capture new values

                temp0 = temp1;
                temp1 = res;
            }

            return len;
        }
    }
}
