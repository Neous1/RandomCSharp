using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you enjoy C# ? (yes/no/maybe)");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "yes":
                case "maybe":
                    Console.WriteLine("Great!");
                    break;
                case "no":
                    Console.WriteLine("Too bad!");
                    break;
                default:
                    Console.WriteLine("I'm sorry, I don't understand that!");
                    break;
            }
        }
    }
}
