namespace UdemyCreateMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer1 = Add(5, 19);
            int answer2 = Add(answer1, 23);

            Console.WriteLine(answer1);
            Console.WriteLine(answer2);

            int x = int.Parse(Console.ReadLine());
            int answer = Add(x, 5);

            Console.WriteLine(answer);
        }

        public static int Add(int num1, int num2) 
        {
            int sum = num1 + num2;
            return sum;
        }
    }
}