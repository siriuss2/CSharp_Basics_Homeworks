using SEDC.HomeWork_Class._06_Task02.Models;

Card[] cards = new Card[] { };

Console.WriteLine("Welcome to the ATM app! Please press 1 to register and continue to use our application!");
int userChoice;
bool isUserChoiceValid = int.TryParse(Console.ReadLine(), out userChoice);
int balance = 10000;

if (isUserChoiceValid)
{
    if (userChoice == 1)
    {
        bool userExists = false;

        Console.Write("First name:");
        string newUserName = Console.ReadLine();

        Console.Write("Last name:");
        string newUserLastName = Console.ReadLine();

        Console.Write("Enter the card number (Take note to input it like this ####-####-####-####):");
        string newUserCardNumber = Console.ReadLine();

        Console.Write("Enter pin:");
        int newUserPin = int.Parse(Console.ReadLine());

        if (!userExists)
        {
            Array.Resize(ref cards, cards.Length + 1);

            cards[cards.Length - 1] = new Card(newUserName, newUserLastName, newUserPin, newUserCardNumber);

            for (int i = 0; i < cards.Length; i++)
            {
                Console.WriteLine($"Welcome {cards[i].Name} {cards[i].LastName}. What would you like to do? \n1.Check Balance \n2.Cash Withdrawal \n3.Cash Deposit");

                int userInput;
                bool isInputFound = int.TryParse(Console.ReadLine(), out userInput);

                if (isInputFound)
                {
                    if (userInput == 1)
                    {
                        Console.WriteLine($"You have {balance}$ at your account!");
                    }
                    if (userInput == 2)
                    {
                        Console.WriteLine("Enter the amount of dollars you want to withdraw:");
                        int withdrawMoney = int.Parse(Console.ReadLine());

                        if (balance >= withdrawMoney)
                        {
                            Console.WriteLine($"You withdrawed {withdrawMoney}$ now your balance is {balance - withdrawMoney}");
                        }

                        else if (balance < withdrawMoney)
                        {
                            Console.WriteLine("You dont have that amount of money on your account!");
                        }
                    }
                    if (userInput == 3)
                    {
                        Console.WriteLine("How much money do you want to deposit:");
                        int userDepositMoney = int.Parse(Console.ReadLine());

                        Console.WriteLine($"You deposited {userDepositMoney}$ now your balance is {balance + userDepositMoney}$");
                    }
                }

                else
                {
                    Console.WriteLine("Please enter number between 1-3. No other inputs are valid.");
                }

            }

        }

    }

    else
    {
        Console.WriteLine("Please enter 1! No other input is accepted!");
    }

}

else
{
    Console.WriteLine("Please enter 1! No other input is accepted!");
}
