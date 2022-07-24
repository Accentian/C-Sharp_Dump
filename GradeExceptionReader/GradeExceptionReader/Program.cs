using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeExceptionReader
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double total = 0;


            // Chapter 7.3 Example of reading files
            try
            {
                const int SIZE = 20;
                double[] content = new double[SIZE];

                int index = 0;
                StreamReader inputFile;
                inputFile = File.OpenText("input.txt");

                while (index < content.Length && !inputFile.EndOfStream)
                {

                    if (double.TryParse(content[index].ToString(), out double output))
                    {
                        content[index] = double.Parse(inputFile.ReadLine());
                        total += content[index];
                    }
                    else
                    {
                        content[index] = content[index].ToString();
                    }
                        

                    

                    index++;
                } // End while loop

                // Close file
                inputFile.Close();

                foreach (double val in content)
                {
                    
                } // End foreach loop

                StreamWriter outputFile;
                outputFile = File.AppendText("output.txt");

            } // End try

            catch
            {

            } // End catch

        } // End main
    } // End class

    class GradeException : Exception
    {
        public void LowAverageException()
        {
            Console.WriteLine("Average not up to NC State standards. Class is eliminated.");
        } // End method

        public void NegativeGradeException()
        {
            Console.WriteLine("Invalid data. Please check file.");
        } // End method

        public void NoNameException()
        {
            Console.WriteLine("Missing name for scores.");
        } // End method

    } // End GradeException Class



} // End namespace
