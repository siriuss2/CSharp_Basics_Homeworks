int AgeCalculator(DateTime birthdayDate)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthdayDate.Year;
    if (birthdayDate > today.AddYears(-age))
    {
        age--;
    }
    return age;
}

DateTime myBirthday = new DateTime(1992, 3, 13);
int myAge = AgeCalculator(myBirthday);
Console.WriteLine($"I am {myAge} years old");