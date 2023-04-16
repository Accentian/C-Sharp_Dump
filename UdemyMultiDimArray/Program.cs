// The commas denotes the dimension of arrays. Two commas means 3D array
int[,] arr = new int[3, 4];

// Row, Column
arr[0, 0] = 5;
arr[0, 1] = 6;
arr[0, 2] = 7;
arr[0, 3] = 8;

arr[1, 0] = 5;
arr[1, 1] = 6;
arr[1, 2] = 7;
arr[1, 3] = 8;

arr[2, 0] = 5;
arr[2, 1] = 6;
arr[2, 2] = 7;
arr[2, 3] = 8;

for (int i = 0;i < 3; i++)
{
    for(int j = 0; j < 4; j++)
    {
        Console.Write(arr[i,j]);
    }
    Console.WriteLine();
}

Console.WriteLine();

// Alternative
//int[,] myArr = { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9 } };

// Jagged array - array of arrays
int[][] arr2 = new int[3][];
arr2[0] = new int[4] { 5, 6, 7, 8 };
arr2[1] = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
arr2[2] = new int[2] { 1, 2 };

for (int i = 0; i < arr2.Length; i++)
{
    // Get length of rows
    for (int j = 0; j < arr2[i].Length; j++)
    {
        Console.Write(arr2[i][j]);
    }
    Console.WriteLine();
}

