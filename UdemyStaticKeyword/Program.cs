namespace UdemyStaticKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ted", 12);
            Person p2 = new Person("Bob", 22);

            // We can access Count through the actual class itself
            Console.WriteLine(Person.Count);
            Test();
        }

        // Main can't see non-static instance. You need static
        public static void Test()
        {
            Console.WriteLine("Testing");
        }
    }
}