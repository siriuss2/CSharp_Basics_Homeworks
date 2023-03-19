using SEDC.Homework_Task_01.Models;
using System.Threading.Channels;

Console.WriteLine("Enter first name:");
string firstName = Console.ReadLine();

Console.WriteLine("Enter last name:");
string lastName = Console.ReadLine();

Console.WriteLine("Enter your age:");
int age;
bool isValid = int.TryParse(Console.ReadLine(), out age);

if (isValid)
{
    Human human = new Human()
    {
        FirstName = firstName,
        LastName = lastName,
        Age = age

    };

    string personDetails = human.GetPersonInfo();
    Console.WriteLine(personDetails);
}
else
{
    Console.WriteLine("Please enter valid number");
}