namespace UdemyOperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank1 = new BankAccount(500, "Bob");
            BankAccount bank2 = new BankAccount(1200, "Sam");

            // Calls the implementation possessing BankAccount and BankAccount
            BankAccount bank3 = bank1 + bank2;
            Console.WriteLine(bank3.Owner);
            Console.WriteLine(bank3.Money);

            // Calls the implementation possessing BankAccount and double
            BankAccount bank4 = bank3 + 500;

            Console.WriteLine(bank4.Owner);
            Console.WriteLine(bank4.Money);


        }
    }
}