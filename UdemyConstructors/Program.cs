namespace UdemyConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You must supply all information in the Student class
            Student s1 = new Student("Tom", 15, 77);
            s1.SayHello();

            Student s2 = new Student("Sam", 16, 84);
            s2.SayHello();

            Student s3 = new Student("Bob", 15, 99);
            s3.SayHello();

            Student s4 = new Student("Frank", 10);
            s4.SayHello();
        }
    }
}