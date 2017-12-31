using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> dict = new Dictionary<int, string>()
                //initializing
                {
                    {1, "One"},
                    {2, "Two"},
                    {3, "Three"}

                };
        }
    }
}
