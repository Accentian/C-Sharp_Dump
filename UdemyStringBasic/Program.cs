// See https://aka.ms/new-console-template for more information
string name1 = "Bob";
string name2 = "Jesse";
string name3 = "Sam";
string name4 = "An";


// The compare function returns a -1 (less than), 0 (same), 1 (greater than)
int nameCompare = name1.CompareTo(name4);
Console.WriteLine(nameCompare);

nameCompare = string.Compare(name1, name1);
Console.WriteLine(nameCompare);

nameCompare = string.Compare(name2, name3);
Console.WriteLine(nameCompare);

bool nameEqual= string.Equals(name1, name2);
Console.WriteLine(nameEqual);

Console.WriteLine("{0} has {1} characters", name2, name2.Length);

string firstCharName = name1.Substring(0, 1);
Console.WriteLine(firstCharName);

string midCharName = name3.Substring(1, 1);
Console.WriteLine(midCharName);

bool startsWith = name2.StartsWith("Je");
Console.WriteLine(startsWith);


