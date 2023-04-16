namespace UdemyMultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            MultiplicationTable(num);

        }

        public static void MultiplicationTable(int num)
        {
            for (int i = 2; i < 11; i++)
            {
                int answer = num * i;
                Console.WriteLine("{0} * {1} = {2}", i, num, answer);
            }
        }

        
    }
}