using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name: ");
            string lastName = Console.ReadLine();

            DisplayFullName(firstName, lastName);

            Console.ReadLine();

        } // End main

        private static void DisplayFullName(string firstName, string lastName)
        {
            Console.WriteLine("Full name is " + firstName + " " + lastName);
        } // End DisplayFullName

    } // End class
} // End namespace
