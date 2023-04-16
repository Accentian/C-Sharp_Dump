namespace UdemyMethodOverloading
{
    internal class Program
    {
        // Method overloading allows you to declare the same method multiple times with different argument lists 
        static void Main(string[] args)
        {
            Add(5, 6);
            Add(7.5, 8.5);
            Add("Hello", "World");
        }

        public static void Add(string x, string y) 
        { 
            string answer = x + " " + y;
            Console.WriteLine(answer);
        }

        public static void Add(int x, int y)
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }

        public static void Add(double x, double y)
        {
            double answer = x + y;
            Console.WriteLine(answer);
        }
    }
}