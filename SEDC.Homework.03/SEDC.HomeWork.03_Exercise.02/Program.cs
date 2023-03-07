string[] studentsG1Array = new string[5] { "Antonio", "Tosho", "Monika", "Marija", "Kostadin" };
string[] studentsG2Array = new string[5] { "Mario", "Ivce", "Dani", "Dejan", "Jovan" };

Console.WriteLine("Enter number (1 / 2)");
int userInput;
bool isValidInput = int.TryParse(Console.ReadLine(), out userInput);

if (isValidInput)
{
    if (userInput == 1)
    {
        Console.WriteLine("The students in G1 are: ");
        for (int i = 0; i < studentsG1Array.Length; i++)
        {
            Console.WriteLine(studentsG1Array[i]);
        }
    }
    else if (userInput == 2)
    {
        Console.WriteLine("The students in G2 are: ");
        for (int i = 0; i < studentsG2Array.Length; i++)
        {
            Console.WriteLine(studentsG2Array[i]);
        }
    }
    else
    {
        Console.WriteLine("You entered wrong number! Please enter 1 or 2.");
    }
}
else
{
    Console.WriteLine("You entered string! Please enter valid integer");
 
}
