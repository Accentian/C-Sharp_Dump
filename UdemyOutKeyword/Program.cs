namespace UdemyOutKeyword
{
    internal class Program
    {
        // The out keyword doesn't require a inital value
        // Out keyword allows you to return multiple values
        static void Main(string[] args)
        {
            int sum;
            int total;
            AddAndMultiply(5, 10, out sum, out total);
            Console.WriteLine(sum);
            Console.WriteLine(total);
        }

        public static void AddAndMultiply(int a, int b, out int sum, out int total)
        {
            sum = a + b;
            total = a * b;
        }
    }
}