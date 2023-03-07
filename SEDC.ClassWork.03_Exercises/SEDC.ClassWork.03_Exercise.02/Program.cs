int[] intArray = new int[5];

int sum = 0;

for (int i = 0; i < intArray.Length; i++)
{
    Console.Write($"Enter the value for {i + 1} number ");
    intArray[i] = int.Parse(Console.ReadLine());
    sum += intArray[i];
}

Console.WriteLine("The sum of the numbers in the array is: " + sum);
