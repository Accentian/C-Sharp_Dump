using static System.Formats.Asn1.AsnWriter;
int[] grades = { 69, 93, 39, 95, 100 };

/*
 * foreach loop is READ ONLY and is useful for displaying or accessing values in a linear fashion
 * You also cannot change the order of the array (backward, even index only, etc.)
 */
foreach (int score in grades)
{  
    Console.WriteLine(score);
}

Console.WriteLine("\nAdd extra credits:");

// Use length method to get array size and add 3 into the array elements
for (int i = 0; i < grades.Length; i++)
{
    grades[i] += 3;
    Console.WriteLine(grades[i]);
}

Console.WriteLine("\nAdd extra credits backwards:");

// This for loop goes backwards.
for (int i = grades.Length - 1; i >= 0; i--)
{
    grades[i] += 3;
    Console.WriteLine(grades[i]);

}



