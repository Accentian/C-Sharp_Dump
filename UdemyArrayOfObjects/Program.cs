namespace UdemyArrayOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[2];
            array[0] = 11;
            array[1] = 22;

            Person[] peopleArray = new Person[2];
            peopleArray[0] = new Person("Sam", 22);
            peopleArray[1] = new Person("Jack", 29);

            for(int i = 0; i < peopleArray.Length; i++)
            {
                Console.WriteLine("{0}, {1}", peopleArray[i].Name, peopleArray[i].Age);
            }
        }
    }
}