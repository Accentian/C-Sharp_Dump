namespace UdemyClassExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taxpayer[] payers = new Taxpayer[10];
            
            for (int i = 0;i < payers.Length; i++)
            {
                payers[i] = new Taxpayer();
                Console.WriteLine("Enter payer #{0}", i + 1);
                payers[i].SocialSecNum = Console.ReadLine();

                Console.WriteLine("Enter payer #{0} yearly income", i + 1);
                payers[i].YearlyGrossIncome = double.Parse(Console.ReadLine());
            }

            for (int i = 0;i < payers.Length; i++)
            {
                Console.WriteLine("Tax Payer #{0}, SSN = {1}, Income = {2}, Tax Owned = {3}", i + 1, payers[i].SocialSecNum, payers[i].YearlyGrossIncome, payers[i].TaxOwned);
            }
            
        }
    }
}