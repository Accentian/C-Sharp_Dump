namespace UdemyClassExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Job j1 = new Job("Wash windows", 5, 15);
            Console.WriteLine("{0}, {1}, {2}, {3}", j1.JobDesc, j1.TimeToComplete, j1.HourlyRate, j1.TotalFee);

            Job j2 = new Job("Remove trash", 2, 12.50);
            Console.WriteLine("{0}, {1}, {2}, {3}", j2.JobDesc, j2.TimeToComplete, j2.HourlyRate, j2.TotalFee);

            Job j3 = j1 + j2;
            Console.WriteLine("{0}, {1}, {2}, {3}", j3.JobDesc, j3.TimeToComplete, j3.HourlyRate, j3.TotalFee);
        }
    }
}