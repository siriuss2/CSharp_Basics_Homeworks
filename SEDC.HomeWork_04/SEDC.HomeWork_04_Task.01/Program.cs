Console.WriteLine("Please write one word.");
string userInput = Console.ReadLine();

string result = userInput.Substring(userInput.Length - 5);
Console.WriteLine(result);
