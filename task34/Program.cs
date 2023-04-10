/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int n, min, max;

Console.Write("Введите длину массива: ");
n = ReadNumberFromConsole();

Console.Write("Введите минимальное значение элемента массива: ");
min = ReadNumberFromConsole();

Console.Write("Введите максимальое значение элемента массива: ");
max = ReadNumberFromConsole();

int[] array = new int[n];

FillArray(array, min, max);

Console.Write($"{n}, {min}, {max} -> ");

PrintArry(array);

PrintEvenElementsArray(array);

int ReadNumberFromConsole()
{
    string? input = Console.ReadLine();
    return int.Parse(input);
}

void FillArray(int[] array, int min, int max)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
}

void PrintArry(int[] array)
{
    Console.Write("{");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[^1] + "}");
}

void PrintEvenElementsArray(int[] array)
{
    Console.Write(" -> ");
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) counter++;
    }
    Console.WriteLine(counter);
}
