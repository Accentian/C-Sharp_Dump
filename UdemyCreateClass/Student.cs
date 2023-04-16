using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Created by going to Solution Explorer -> Right click project -> Add -> Choose and name the Class
// Class is blueprint and structure for all its objects
namespace UdemyCreateClass
{
    internal class Student
    {
        // Give Attributes
        public string Name;
        public int Age;
        public double FinalGrade;

        // Action
        public void SayHello() 
        {
            Console.WriteLine("Hello from {0}", Name);
        }
    }
}
