namespace UdemyClassExercise1
{
    internal class Program
    {
        /**
         * Calculates the area of a square from 1 to 10
         * With a Class called Square
         */
        static void Main(string[] args)
        {
            Square[] squares = new Square[10];
            
            for (int i = 0; i < 10; i++)
            {
                squares[i] = new Square(i + 1);
                Console.WriteLine("{0}, {1}", squares[i].Side, squares[i].Area);
            }
        }
    }
}