using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace RunMathLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            ReturnInteger compInt = new ReturnInteger();
            int num = compInt.Compare(8, 6);
            Console.WriteLine(num);


            int num1 = compInt.Compare(38, 800, 28);
            Console.WriteLine(num1);


            int num2 = compInt.Compare(55, 29, 9, 10);
            Console.WriteLine(num2);

            Console.ReadLine();


        } // End main

    } // End class

} // End namespace
