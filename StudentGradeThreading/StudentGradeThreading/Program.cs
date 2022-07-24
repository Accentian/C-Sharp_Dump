using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudentGradeThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation1 calc1 = new Calculation1();
            Calculation2 calc2 = new Calculation2();
            Average avg = new Average();

            Console.ReadLine();


        } // End main
    } // End class

    public class Calculation1
    {
        public static double average = 0;

        public Calculation1()
        {
            Thread process = new Thread(new ThreadStart(calcAvg1));
            process.Start();
            
        }

        void calcAvg1()
        {
            int counter = 0;
            double total = 0;
            string line;

            StreamReader file = new StreamReader("student1.txt");

            while((line = file.ReadLine()) != null)
            {
                total += double.Parse(file.ReadLine());
                counter++;
            }

            average = total / counter;

            file.Close();

            Console.WriteLine("The average of Student 1 is: " + average);
        } // End calcAvg1 method

        public double ReturnValue()
        {
            return average;
        } // End method


    } // End class Calculation1

    public class Calculation2
    {
        public static double average = 0;

        public Calculation2()
        {
            Thread process = new Thread(new ThreadStart(calcAvg2));
            process.Start();
        }

        void calcAvg2()
        {
            int counter = 0;
            double total = 0;
            
            string line;

            StreamReader file = new StreamReader("student2.txt");

            while ((line = file.ReadLine()) != null)
            {
                total += double.Parse(file.ReadLine());
                counter++;
            }

            average = total / counter;

            file.Close();

            Console.WriteLine("The average of Student 2 is: " + average);

        } // End calcAvg1 method

        public double ReturnValue()
        {
            return average;
        } // End method

    } // End class Calculation2

    public class Average{

        double average1 = Calculation1.average;
        double average2 = Calculation2.average;

        public Average()
        {
            Thread process = new Thread(finalCalc);
            process.Start();
            process.Join();
        }

        public void finalCalc()
        {
            if (average1 > average2)
            {
                Console.WriteLine("Student 1 has the highest average.");
         }
            else if (average1 < average2)
            {
                Console.WriteLine("Student 2 has the highest average.");
            }
            else
            {
                Console.WriteLine("Both groups' average are tied.");
            }
        } // End method finalCalc
    } // End Average class

} // End namespace
