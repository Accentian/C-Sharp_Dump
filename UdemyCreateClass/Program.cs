namespace UdemyCreateClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using the new keyword is called instantiation - In short, when you create a new object, it's called instantiation
            // Allocating memory is a different memory location
            Student s1 = new Student();
            s1.Name = "Sam";
            s1.Age = 15;
            s1.FinalGrade = 71;
            s1.SayHello();

            Student s2 = new Student();
            s2.Name = "Jack";
            s2.Age = 16;
            s2.FinalGrade = 88;
            s2.SayHello();

            Student s3 = new Student();
            s3.Name = "Ted";
            s3.Age = 15;
            s3.FinalGrade = 98;
            s3.SayHello();

            //Console.WriteLine(s1.Name);

        }
    }
}