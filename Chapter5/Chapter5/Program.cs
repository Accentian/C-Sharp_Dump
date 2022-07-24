using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            } // End while

            // do
            i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 5);

            // for
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(j);
            }

            // Generating a random number
            Random rand = new Random();
            int randNum = rand.Next(1, 10);
            Console.WriteLine("Random number is: " + randNum);

            // Write results to file
            System.IO.StreamWriter file = new System.IO.StreamWriter("testfile1.txt");
            file.WriteLine("Random number is: " + randNum);
            file.WriteLine("Random test");
            file.Close(); // File written to bin>Debug folder

            Console.ReadLine();
        } // End main
    } // End class
} // End namespace
