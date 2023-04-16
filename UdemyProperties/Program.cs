namespace UdemyProperties
{
    internal class Program
    {
        // Properties is C# way of Getters and Setters
        static void Main(string[] args)
        {
            Student s1 = new Student("Tom", "Riddle", 15, 77);

            s1.Name = "Bob";
            Console.WriteLine(s1.Name);

            s1.Age = 14;
            Console.WriteLine(s1.Age);

            s1.FinalGrade = 111;
            Console.WriteLine(s1.FinalGrade);

            // s1.LastName = ""; Cannot be set because the set is private within the Student class
        }
    }
}