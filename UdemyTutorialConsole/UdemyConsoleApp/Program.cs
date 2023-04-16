// See https://aka.ms/new-console-template for more information

int myNum = 6;
double myDouble = 5.67;
string myString = "This is a string!";
bool myBool = true;
char myChar = 'B';


// We can also use placeholders or add empty as seen below.
Console.WriteLine("The value of my number is {0, -6} and takes up -6 spaces. The value of my double is {1, 7} and take up 7 spaces. Also, {2}", myNum, myDouble, myString);

Console.WriteLine();

Console.WriteLine("My character is " + myChar + " and that is " + myBool);
