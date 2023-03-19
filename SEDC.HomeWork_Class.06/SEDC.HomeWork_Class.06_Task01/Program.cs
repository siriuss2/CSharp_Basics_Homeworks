using SEDC.HomeWork_Class._06_Task01.Models;
using System.Globalization;

User firstUser = new User(129481, "sirius", "password", new string[] { "Hello , how are you!", "Have a nice day!" });
User secondUser = new User(123124, "pavich5", "drvarastat1234", new string[] { "Hi guys!", "Bye guys!" });
User thirdUser = new User(452352, "kokikoki", "kokikoki123", new string[] { "Hi again!", "Bye again!" });

User[] messages = new User[3] { firstUser, secondUser, thirdUser };

Console.WriteLine("Choose one of the options below: \n1. Log In \n2. Sign up");
int userInput;
bool isValid = int.TryParse(Console.ReadLine(), out userInput);

if (isValid)
{
    if (userInput == 1)
    {
        Console.Write("Username:");
        string userName = Console.ReadLine();

        bool isUserNameValid = false;

        for (int i = 0; i < messages.Length; i++)
        {
            if (userName.ToLower() == messages[i].Username.ToLower())
            {
                isUserNameValid = true;
                Console.Write("Password:");
                string userPassword = Console.ReadLine();

                for (int j = 0; j < messages.Length; j++)
                {
                    if (userPassword.ToLower() == messages[j].Password.ToLower())
                    {
                        Console.WriteLine($"Welcome {messages[j].Username}! \n {messages[j].Messages[0]}\n {messages[j].Messages[1]}");
                        break;
                    }
                    else if (j == messages.Length - 1)
                    {
                        Console.WriteLine("Password does not exist");
                    }
                }
                break;
            }
        }

        if (!isUserNameValid)
        {
            Console.WriteLine("That username does not exist! ");
        }

    }
    if (userInput == 2)
    {
        Console.WriteLine("Please fill the informations below:");

        Console.Write("ID:");
        int newUserInputForID;
        bool isIDValid = int.TryParse(Console.ReadLine(), out newUserInputForID);


        if (isIDValid)
        {
            Console.Write("Username:");
            string newUserInputForUserName = Console.ReadLine();

            Console.Write("Password:");
            string newUserInputForPassword = Console.ReadLine();

            bool usernameExists = false;

            for (int i = 0; i < messages.Length; i++)
            {
                if (newUserInputForUserName == messages[i].Username)
                {
                    Console.WriteLine("This username already exists! Please write a new one.");
                    usernameExists = true;
                    break;
                }
            }

            if (!usernameExists)
            {
                Array.Resize(ref messages, messages.Length + 1);
                messages[messages.Length - 1] = new User(newUserInputForID, newUserInputForUserName, newUserInputForPassword);

                for (int i = 0; i < messages.Length; i++)
                {
                    Console.WriteLine($" Id: {messages[i].Id} | Username: {messages[i].Username} | Password: {messages[i].Password}");
                }
            }
            else
            {
                Console.WriteLine("Please enter valid ID number!");
            }
        }


    }


}

else
{
    Console.WriteLine("Please enter 1 or 2! No other input is valid.");
}


