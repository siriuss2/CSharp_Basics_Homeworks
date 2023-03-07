string[] namesArray = new string[int.MaxValue];
int index = 0;
string input = "";

do
{
    Console.Write("Enter a name: ");
    input = Console.ReadLine();
    namesArray[index] = input;
    index++;

    Console.Write("Do you want to enter another name? (Y/N): ");
    input = Console.ReadLine();
}
while (input.ToUpper() == "Y");

Console.WriteLine("All entered names:");
for (int i = 0; i < index; i++)
{
    Console.WriteLine(namesArray[i]);
}