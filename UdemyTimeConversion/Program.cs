// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the total amount of time in minutes:");
int totalMinutes = int.Parse(Console.ReadLine());

// 60 minutes = 1 hour. Use the % operator to get the remaining minutes
int hours = totalMinutes / 60;
int remainingMinutes = totalMinutes % 60;

Console.WriteLine("{0} minutes is equal to {1} hour(s) and {2} minutes.", totalMinutes, hours, remainingMinutes);
