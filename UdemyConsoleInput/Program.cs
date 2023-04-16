// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("Hello {0}", name);
Console.WriteLine();

// ReadLine will always take in a string. Convert it to something else
Console.WriteLine("Enter a number:");
double number = int.Parse(Console.ReadLine());
number *= 5;
Console.WriteLine("The new number is {0}", number);


