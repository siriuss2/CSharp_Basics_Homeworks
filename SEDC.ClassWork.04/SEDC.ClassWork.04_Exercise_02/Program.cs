DateTime threeDaysFromNow = DateTime.Now.AddDays(3);
Console.WriteLine($"Three days from now: {threeDaysFromNow}");

DateTime oneMonthFromNow = DateTime.Now.AddMonths(1);
Console.WriteLine($"One month from now: {oneMonthFromNow}");

DateTime oneMonthThreeDaysFromNow = DateTime.Now.AddMonths(1).AddDays(3);
Console.WriteLine("One month and three days from now is: " + oneMonthThreeDaysFromNow.ToShortDateString());

DateTime oneYearTwoMonthsAgo = DateTime.Now.AddYears(-1).AddMonths(-2);
Console.WriteLine("One year and two months ago was: " + oneYearTwoMonthsAgo.ToShortDateString());

Console.WriteLine("The current month is: " + DateTime.Now.Month);

Console.WriteLine("The current year is: " + DateTime.Now.Year);
