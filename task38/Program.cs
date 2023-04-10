/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
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

Console.WriteLine($" -> {FindMax(array) - FindMin(array)}");

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

int FindMin(int[] array)
{
    int min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(min > array[i]) min = array[i];
    }
    return min;
}

int FindMax(int[] array)
{
    int max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(max < array[i]) max = array[i];
    }
    return max;
}