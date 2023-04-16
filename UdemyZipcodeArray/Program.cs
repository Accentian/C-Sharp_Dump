string[] zipcode = { "29594", "10000", "25940", "18584", "66666", "12345" };
Console.WriteLine("Enter a zipcode");
string input = Console.ReadLine();

bool found = false;

for (int i = 0;i < zipcode.Length; i++)
{
    if (input == zipcode[i])
    {
        found = true;
        break;
    }
}
if (found)
{
    Console.WriteLine("Zipcode found!");
}
else
{
    Console.WriteLine("Zipcode not found!");
}
    
    
