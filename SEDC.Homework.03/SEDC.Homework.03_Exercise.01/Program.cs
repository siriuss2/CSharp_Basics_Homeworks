int[] numbersArray = new int[6];
int sum = 0;

for (int i = 0; i < numbersArray.Length; i++)
{
    Console.WriteLine($"Write the {i + 1} number: ");
    int inputNumber;
    if (int.TryParse(Console.ReadLine(), out inputNumber))
    {
        numbersArray[i] = inputNumber;
        if (numbersArray[i] % 2 == 0)
        {
            sum += numbersArray[i];
        }
    }
    else
    {
        Console.WriteLine("Invalid input.Please enter a valid number.");
        i--; 
    }
}

Console.WriteLine("The result is: " + sum);
