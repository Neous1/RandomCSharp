﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            student.Code = "0001";
            student.Name = "";
            //student.Age = 9;
            Console.WriteLine("Student Info: {0}", student);
        }
    }
}
