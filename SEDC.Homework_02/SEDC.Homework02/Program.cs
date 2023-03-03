#region Exercise 01

Console.WriteLine("Enter the first number: ");
double firstUserNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
double secondUserNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the operation: ");
char userOperation = char.Parse(Console.ReadLine());

switch (userOperation)
{
    case '+':
        Console.WriteLine("The result is: " + (firstUserNumber + secondUserNumber));
        break;
    case '-':
        Console.WriteLine("The result is: " + (firstUserNumber - secondUserNumber));
        break;
    case '*':
        Console.WriteLine("The result is: " + (firstUserNumber * secondUserNumber));
        break;
    case '/':
        Console.WriteLine("The result is: " + (firstUserNumber / secondUserNumber));
        break;


    default:
        Console.WriteLine("Wrong operation! Please enter the correct one");
        break;
}
#endregion