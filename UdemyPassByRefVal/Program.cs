namespace UdemyPassByRefVal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pass by Values
            int studentGrade = 75;
            Console.WriteLine("Student grade before EC: {0}", studentGrade);

            GiveExtraCredit(studentGrade);
            Console.WriteLine("Student grade after EC: {0}", studentGrade);

            Console.WriteLine();

            // Pass by Reference - Passes the entire array itself
            int[] grades = new int[1];
            grades[0] = 95;
            Console.WriteLine("Student grade array before EC: {0}", grades[0]);

            GiveExtraCreditArray(grades);
            Console.WriteLine("Student grade array after EC: {0}", grades[0]);
        }

        public static void GiveExtraCredit(int studentGrade)
        {
            studentGrade += 3;
            Console.WriteLine("Student grade after EC inside function: {0}", studentGrade);
        }

        public static void GiveExtraCreditArray(int[] grades)
        {
            grades[0] += 3;
        }
    }
}