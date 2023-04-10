/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

PrintSumOfOddCellsArray(array);

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

void PrintSumOfOddCellsArray(int[] array)
{
    Console.Write(" -> ");
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    Console.WriteLine(sum);
}