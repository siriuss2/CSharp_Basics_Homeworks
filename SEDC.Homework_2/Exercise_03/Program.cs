Console.WriteLine("Enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("After Swapping:");
firstNumber = firstNumber * secondNumber;
secondNumber = firstNumber / secondNumber;
firstNumber = firstNumber / secondNumber;

Console.WriteLine("First number: " + firstNumber);
Console.WriteLine("Second number: " + secondNumber);
