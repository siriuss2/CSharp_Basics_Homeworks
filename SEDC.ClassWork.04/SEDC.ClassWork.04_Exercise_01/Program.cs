void Substrings()
{
    string mainString = "Hello from SEDC Codecademy 2021";
    Console.WriteLine(mainString);

    Console.WriteLine("Please enter a number");
    int userInput;
    bool isValid = int.TryParse(Console.ReadLine(), out userInput);

    if (isValid)
    {
        if (userInput > mainString.Length)
        {
            Console.WriteLine("The number that you entered is bigger than the length of the sentence!");
        }
        else
        {
            string substring = mainString.Substring(0, userInput);
            Console.WriteLine($"The first {userInput} characters of the sentence are: {substring}");
            Console.WriteLine($"The length of the new string is: {substring.Length}");
        }
    }
    else
    {
        Console.WriteLine("The input is not a valid integer!");
    }

}

Substrings();