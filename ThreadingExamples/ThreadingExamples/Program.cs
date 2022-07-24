using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1 task1 = new Task1();
            Task2 task2 = new Task2();
            Console.ReadLine();

        } // End main
    } // End class

    public class Task1
    {
        public Task1()
        {
            Thread t1 = new Thread(new ThreadStart(fahr2cel));
            t1.Start();
            t1.Join();
        }

        void fahr2cel()
        {
            for(int f = 1; f < 100; f++)
            {
                Console.WriteLine(f + " degrees Fahr is " + ((f - 32)/1.8) + " degrees CELCIUS");
            } // End for
        } // End method fahr2cel

    } // End Task1

    public class Task2
    {
        public Task2()
        {
            Thread t2 = new Thread(new ThreadStart(fahr2kel));
            t2.Start();
        }

        void fahr2kel()
        {
            for (int f = 1; f < 100; f++)
            {
                Console.WriteLine(f + " degrees Fahr is " + ((f + 459.67) / 1.8) + " degrees KELVIN");
            } // End for
        } // End method fahr2cel

    } // End Task2

} // End namespace
