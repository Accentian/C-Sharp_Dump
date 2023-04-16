namespace UdemyGettersSetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Tom", 15, 77);

            s1.SetName("");
            Console.WriteLine(s1.GetName());

            s1.SetFinalGrade(155);
            Console.WriteLine(s1.GetFinalGrade());

            s1.SayHello();
            

            //Student s2 = new Student("Sam", 16, 84);
            //s2.SayHello();

            //Student s3 = new Student("Bob", 15, 99);
            //s3.SayHello();

            //Student s4 = new Student("Frank", 10);
            //s4.SayHello();
        }
    }
}