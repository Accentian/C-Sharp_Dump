// Binary search: Cut down the search space depending on the situtation
int[] myArr = { 10, 22, 35, 44, 66, 94, 100 };

// Best used if there's a middle index and should be sorted
Console.WriteLine("Enter a number:");
int number = int.Parse(Console.ReadLine());

int answer = Array.BinarySearch(myArr, number);
if(answer < 0)
{
    Console.WriteLine("The number does not exist. \n");
}
else
{
    Console.WriteLine("THe number position is {0} \n", answer);
}


int[] arr = { 10, 5, 7, 2, 55 };
Array.Sort(arr);

for(int i = 0;i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

Array.Reverse(arr);
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}