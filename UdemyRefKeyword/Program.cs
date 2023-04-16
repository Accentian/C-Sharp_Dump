namespace UdemyRefKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentGrade = 75;

            // Passes the location of the variable in memory. Any changes made in the function will affect the variable.
            GiveExtraCredit(ref studentGrade);
            Console.WriteLine(studentGrade);
        }

        // The ref keyword allows you to make changes to the variable inside the function
        public static void GiveExtraCredit(ref int studentGrade)
        {
            studentGrade += 3;
        }


    }
}