// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = Convert.ToInt32(new Random().Next(0, 100));
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t");
    Console.WriteLine();
}

Console.Write("Введите номер строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > m || b > n) Console.WriteLine("Такой позиции в массиве нет.");
else
{
    int c = array[a,b];
    Console.WriteLine($"Число в заданной позиции: {c}");
}