using System.Security.Cryptography;

namespace UdemyPassingObjects
{
    internal class Program
    {
        // Passing Objects to Methods
        static void Main(string[] args)
        {
            Person p1 = new Person("Bob", 22);
            Console.WriteLine("BEFORE: {0}, {1}", p1.Name, p1.Age);

            ChangePerson(p1);

            Console.WriteLine("AFTER: {0}, {1}", p1.Name, p1.Age);

            // Another change
            Person p2 = new Person("Sam", 30);
            Console.WriteLine("BEFORE: {0}, {1}", p2.Name, p2.Age);
            p2.Name = "TEST";
            Console.WriteLine("AFTER Alter: {0}, {1}", p2.Name, p2.Age);

        }

        public static void ChangePerson(Person p1)
        {
            p1.Name = "Jack";
            p1.Age = 25;
        }
    }
}