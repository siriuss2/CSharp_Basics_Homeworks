Console.WriteLine("Write one sentence");
string userInput = Console.ReadLine();
string[] splittedString = userInput.Split(" ");

for (int i = 0; i < splittedString.Length; i++)
{
    Console.WriteLine(splittedString[i]);
}