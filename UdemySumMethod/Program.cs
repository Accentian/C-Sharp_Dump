namespace UdemySumMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Sum(5);
            Sum(5, 10, 15);
            Sum(5, 10, 15, 20, 25);

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, };
            Sum(array);
        }

        public static void Sum(params int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine("The sum is {0}", sum);
        }
    }
}