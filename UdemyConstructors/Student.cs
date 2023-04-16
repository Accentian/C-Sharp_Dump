using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyConstructors
{
    internal class Student
    {
        private string name;
        private int age;
        private double finalgrade;

        // You want to let the user give you the values through this constructor call
        public Student(string name, int age, double finalgrade)
        {
            // Link the constructors to the private variables
            // Note that this keyword refers to the variables inside this Student constructor
            this.name = name;
            this.age = age;
            this.finalgrade = finalgrade;
        }

        // What if we don't have the grades yet? We can overload the constructor doing this below
        // To prevent duplicate codes, we use constructor initializer as seen below 
        public Student(string name, int age) : this(name, age, 0)
        {
            //this.name = name;
            //this.age = age;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", name);
        }
    }
}
