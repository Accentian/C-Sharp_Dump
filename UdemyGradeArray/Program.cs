Console.WriteLine("Enter the amount of student in class:");
int studentAmount = int.Parse(Console.ReadLine());

string[] names = new string[studentAmount];
double[] grades = new double[studentAmount];

double avgGrade = 0, highestGrade = 0;
string highestGradeName = "";

for (int i = 0; i < studentAmount; i++)
{
    Console.WriteLine("Enter student #{0} name", i + 1);
    string nameEntry = Console.ReadLine();
    names[i] = nameEntry;

    Console.WriteLine();

    Console.WriteLine("Enter student #{0} grade", i + 1);
    double gradeEntry = double.Parse(Console.ReadLine());
    grades[i] = gradeEntry;
    avgGrade += gradeEntry;

    Console.WriteLine();

    if (gradeEntry > highestGrade)
    {
        highestGrade = gradeEntry;
        highestGradeName = nameEntry;
    }
}

// Print
avgGrade /= studentAmount;
Console.WriteLine("The average grade of the class is {0}", avgGrade);
Console.WriteLine("The highest grade of the class is {0} and there name is {1}", highestGrade, highestGradeName);
