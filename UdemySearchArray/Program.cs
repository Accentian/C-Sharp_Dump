string[] students = { "Bob", "Ted", "Tom", "Sam" };
int[] grades = { 85, 42, 83, 94 };

Console.WriteLine("Enter student name:");
string searchName = Console.ReadLine();

bool contains = false;
int studentGrades = 0;
for (int i = 0;i < students.Length; i++)
{
    if (searchName == students[i])
    {
        contains = true;
        studentGrades = grades[i];
        break;
    }
}

if (contains)
{
    Console.WriteLine("Student is in the class");
    Console.WriteLine("Student grade is: {0}", studentGrades);
}
else
{
    Console.WriteLine("Student is not in the class");
}
