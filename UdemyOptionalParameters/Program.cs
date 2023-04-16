using System.Runtime.CompilerServices;

namespace UdemyOptionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add(5);
            // This will make z = 5 in Add()
            Add(5, z : 5);
        }

        // The y variable is default if no value for it was passed
        // 
        public static void Add(int x, int y = 1, int z = 2)
        {
            int answer = x + y + z;
            Console.WriteLine(answer);
        }
    }
}