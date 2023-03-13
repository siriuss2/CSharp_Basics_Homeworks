int SumOfAllDigits(int number)
{
    int sum = 0;

    while (number > 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }

    return sum;
}

int result = SumOfAllDigits(11243);
Console.WriteLine(result);