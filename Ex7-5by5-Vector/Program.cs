int size = 10;
int[] numbers = new int[size];

Console.WriteLine("Value insert\n");

for (int i = 0; i < size; i++)
{
    Console.Write($"Type the {i + 1}° value: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nEven values");

for (int i = 0; i < size; i++)
{
    if (numbers[i] % 2 == 0)
        Console.Write($"{numbers[i]} ");
}

Console.WriteLine("\nOdd values");

for (int i = 1; i < size; i += 2)
{
    if (numbers[i] % 2 != 0)
        Console.Write($"{numbers[i]} ");
}

Console.WriteLine("\nFirst and last positions");

for (int i = 0; i < size; i++)
{
    if (i == 0 || i == size - 1)
        Console.Write($"{numbers[i]} ");
}

Console.WriteLine("\n\nPress any key to exit...");
Console.ReadKey();