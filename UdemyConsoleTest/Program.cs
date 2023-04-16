// See https://aka.ms/new-console-template for more information

// This will do an integer division
double myNum = 45 / 2;
Console.WriteLine(myNum);

// This will do a double division
double myDou = 45.0 / 2;
Console.WriteLine(myDou);

double remainder = 5 % 4;
Console.WriteLine(remainder);

// Note that there's an Order of Operations
double result = 2 + 3 * 4;
Console.WriteLine("The result is {0}", result);

double total = myNum + myDou + remainder + result;
Console.WriteLine("Adding them all is {0}", total);

// To add one to x
int x = 2;
Console.WriteLine("The value of x = {0}", x);

x *= 5;
Console.WriteLine("The value of x = {0}", x);

// Note how the forward ++ is executed first while back ++ executes later. Take that into consideration.
int a = 2;
int b = a++;
Console.WriteLine("The value of a is {0} and the value of b is {1}", a, b);

a = 2;
b = ++a;
Console.WriteLine("The value of a is {0} and the value of b with front ++ is {1}", a, b);

// Numeric Conversions
double g = 5.5;
int theInt = (int)g;
Console.WriteLine(theInt);