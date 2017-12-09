using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Student
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "Code = "+Code +", Name = "+ Name+ ", Age = " + Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            student.Code = "0001";
            student.Name = "Zara";
            student.Age = 9;
            Console.WriteLine("Student Info: {0}", student);
        }
    }
}
