namespace UdemyParamsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, };
            PrintArray(array);

            Console.WriteLine();

            // Doesn't work without params, all will be attached and grouped into the array in the parameter
            // Allows the passing of infinite value/reference
            PrintArray(6, 6, 6, 3, 5, 6, 5, 2, 44, 55, 66);
        }

        public static void PrintArray(params int[] array)
        {
            for (int i = 0;i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}