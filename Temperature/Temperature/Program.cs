using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fahrenheit Temperature: ");
            string fahr = Console.ReadLine();

            if (Double.Parse(fahr) > 150)
            {
                Console.WriteLine("Too high, start again.");
            } // End if

            else if (Double.Parse(fahr) < -150)
            {
                Console.WriteLine("Too low, start again.");
            } // End if
            else
            {
                double celsius = (Double.Parse(fahr) - 32) * 5/9;
                Console.WriteLine("Answer is " + celsius + " degrees.");
            } // End else

            // Pause your screen line
            Console.ReadLine();

        } // End Main

    } // End class
} // End namespace
