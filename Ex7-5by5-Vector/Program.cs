int size = 10;
int[] numbers = new int[size];

Console.WriteLine("Value insertion\n");

for (int i = 0; i < size; i++)
{
    Console.Write($"Type the {i + 1}° value: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\n\nEven values");

for (int i = 0; i < size; i++)
{
    if (numbers[i] % 2 == 0)
        Console.Write($"{numbers[i]} ");
}

Console.WriteLine("\n\nOdd values");

for (int i = 0; i < size; i++)
{
    if (numbers[i] % 2 != 0)
        Console.Write($"{numbers[i]} ");
}

Console.WriteLine("\n\nFirst and last positions");

Console.Write($"{numbers[0]} ");
Console.Write($"{numbers[size - 1]} ");

Console.WriteLine("\n\nPress any key to exit...");
Console.ReadKey();