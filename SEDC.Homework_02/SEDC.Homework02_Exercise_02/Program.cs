Console.WriteLine("Enter first number: ");
int userInput1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int userInput2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter third number: ");
int userInput3 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter fourth number: ");
int userInput4 = int.Parse(Console.ReadLine());

int sumOfAllInputs = userInput1 + userInput2 + userInput3 + userInput4;

int resultOfAverageNumber = sumOfAllInputs / 4;
Console.WriteLine("The average of the 4 numbers above is: " + resultOfAverageNumber);