using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyStaticKeyword
{
    internal class Person
    {
        /**
         * Static means whatever is denoted as Static is applied to the entire class
         * If it's not static, then it is instance
         */
        
        // Instance variables have no static
        private string name;
        private int age;

        public static int Count;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;

            Count++;
        }

        // Instance properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
