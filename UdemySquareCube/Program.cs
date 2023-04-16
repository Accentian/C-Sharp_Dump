namespace UdemySquareCube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            int squared = Square(num);
            Console.WriteLine("{0} squared is {1}", num, squared);

            int cubed = Cube(num);
            Console.WriteLine("{0} cubed is {1}", num, cubed);
        }
        public static int Square(int num)
        {
            int answer = num * num;
            return answer;
        }

        public static int Cube(int num)
        {
            int answer = Square(num) * num;
            return answer;
        }

        
    }
}