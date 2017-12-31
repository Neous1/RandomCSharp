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
            dict.Add(new KeyValuePair<int, string>(4, "Four"));
            dict.Add(new KeyValuePair<int, string>(5, "Five"));
            dict.Add(6, "Six");

            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("key: {0}, Value: {1}", item.Key, item.Value);
            }
        }
    }
}
