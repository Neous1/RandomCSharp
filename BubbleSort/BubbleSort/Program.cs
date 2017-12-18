using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = {89, 76, 45, 92, 67, 12, 99};
            bool flag = true;
            int temp;
            int numlength = number.Length;

           
            for (int i = 1; (i <= (numlength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numlength - 1); j++)
                {
                    if (number[j + 1] > number[j])
                    {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            foreach (var num in number)
            {
                Console.WriteLine("\t{0}",num);
            }
        }
    }
}
