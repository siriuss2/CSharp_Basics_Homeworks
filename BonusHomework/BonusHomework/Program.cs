int amountOfMoney = 1000;

while (true)
{
    Console.WriteLine("Select option: 1(Check Balance) or 2(Withdraw Money)");
    int userInput;
    bool isValidInput = int.TryParse(Console.ReadLine(), out userInput);
    if (isValidInput)
    {
        if (userInput == 1)
        {
            Console.WriteLine($"You have {amountOfMoney}$ at your bank account");
        }

        if (userInput == 2)
        {
            Console.WriteLine("What amount of money do you want to withdraw? ");
            int userInput2;
            bool isValidInput2 = int.TryParse(Console.ReadLine(), out userInput2);

            if (isValidInput2)
            {
                if (userInput2 <= amountOfMoney)
                {
                    Console.WriteLine($"You withdrawed {userInput2}$ and now your account balance is {amountOfMoney - userInput2}$");
                }
                else
                {
                    Console.WriteLine($"You cannot withdraw {userInput2} because your balance is {amountOfMoney}. Please try again with appropriate amount! ");
                }
            }
            else
            {
                Console.WriteLine("Please enter valid number!");
            }
        }
    }

    else
    {
        Console.WriteLine("Please enter valid input!");
    }

    Console.WriteLine("Do you want to take some other actions? (Y/N)");
    string input = Console.ReadLine();

    if (input.ToUpper() == "Y")
    {
        continue;
    }

    else if (input.ToUpper() == "N")
    {
        break;
    }
    else
    {
        Console.WriteLine("Please enter Y or N");
    }
}


