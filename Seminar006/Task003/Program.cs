// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
// Amn = m+n. Выведите полученный массив на экран.

int[,] array = new int[5, 5];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = i + j;
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i,j]}, ");
    }
    Console.WriteLine();
}