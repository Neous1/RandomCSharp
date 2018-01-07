using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* a jagged array of 5 array of intergers*/
            int [][] a = new int[][] {new int[] {0,0}, new int[] {1,2},
                new int[] {2,4},new int[] {3,6}, new int[] {4,8}};
            

            /* output each array element's value */
            for ( int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[1][j]);
                }
            }
            Console.ReadLine();
        }
    }
}
