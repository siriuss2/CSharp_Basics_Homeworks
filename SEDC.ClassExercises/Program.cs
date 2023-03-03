
#region Exercise 01

int appleValue = 8;
int basketValue = 5;
int branchValue = 12;
int totalApplesOnBranches = appleValue * branchValue;

Console.WriteLine("Number of trees: ");
int userInput = int.Parse(Console.ReadLine());
int sum = userInput * totalApplesOnBranches / basketValue;

Console.WriteLine("For " + userInput + " tree/s you will need " + sum + " brackets");

#endregion

#region Exercise 02
Console.WriteLine("Enter first number: ");
int userInput1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int userInput2 = int.Parse(Console.ReadLine());
int largerNumber;

if (userInput1 > userInput2)
{
    Console.WriteLine("The bigger number is: " + userInput1);
    largerNumber = userInput1;
}
else
{
    Console.WriteLine("The bigger number is: " + userInput2);
    largerNumber = userInput2;

}

if (largerNumber % 2 == 0)
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is odd");
}

#endregion

#region Exercise 03

Console.WriteLine("Enter number from 1 to 3");
int newUserInput = int.Parse(Console.ReadLine());
switch (newUserInput)
{
	case 1:
        Console.WriteLine("You got a new car!");
        break;
    case 2:
        Console.WriteLine("You got a new plane!");
        break;
    case 3:
        Console.WriteLine("You got a new bike!");
        break;

    default:
        Console.WriteLine("Error! You entered number which is larger than 3!");
        break;
}

#endregion