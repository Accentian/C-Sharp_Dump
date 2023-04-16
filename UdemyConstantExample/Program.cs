


// See https://aka.ms/new-console-template for more information

// Create an enum


DayOfWeek today = DayOfWeek.Thursday;
Console.WriteLine(today);

int numberOfToday = (int)today;
Console.WriteLine(numberOfToday);

const int myConstInt = 5;
Console.WriteLine("My constant number is {0}", myConstInt);
Console.WriteLine(Math.PI);

enum DayOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}