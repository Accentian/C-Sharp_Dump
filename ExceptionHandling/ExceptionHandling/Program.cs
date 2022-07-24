using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            try
            {
                value = 1 / int.Parse("0");
                Console.WriteLine(value);
            } // End try
            catch (Exception e)
            {
                Console.WriteLine("Message = {0}", e.Message);
                Console.WriteLine("Source = {0}", e.Source);
                Console.WriteLine("Stack Trace = {0}", e.StackTrace);
                Console.WriteLine("Target Site = {0}", e.TargetSite);

            } // End catch

            // Example 2
            int[] numbers = new int[2];
            try
            {
                numbers[0] = 23;
                numbers[1] = 34;
                numbers[2] = 45;

            } // End try
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Error: Index - " + e.Message);
            } // End catch
            finally // Optional - executes no matter what 
            {
                Console.WriteLine("The finally block executed");
            } // End finally


            // Example 3 - Making your own custom exception
            int num = 0, div = 0, result = 0;
            String sNum;
            try {
                Console.WriteLine("Enter the numerator: ");
                sNum = Console.ReadLine();

                if (int.TryParse(sNum,out int output))
                {
                    num = Int16.Parse(sNum);
                } else
                {
                    throw new TestException();
                }
                

                Console.WriteLine("Enter the denominator: ");
                div = Int16.Parse(Console.ReadLine());
                
                //Throw new TestException();

                
            }

            catch (TestException e)
            {
                
                e.NonNumberException();
            }

            try
            {
                if (div == 0)
                {
                    throw new TestException();
                }
                else
                {
                    result = num / div;
                    Console.WriteLine("Result: {0}", result);
                }
            } // End try
            catch (TestException e)
            {
                e.MyDivideException();
            } // End catch

            Console.ReadLine();



        } // End main
    } // End class

    class TestException : Exception
    {
        public void MyDivideException()
        {
            Console.WriteLine("Error occurred - Cannot divide by 0");
        } // End method

        public void NonNumberException()
        {
            Console.WriteLine("Error occurred - Please enter a valid number");
        } // End method

    } // End class






} // End namespace
