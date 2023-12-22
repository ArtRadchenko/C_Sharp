// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] RandFillTwoDimArray(int rows, int colums)
{
    int[,] numbers = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            numbers[i, j] = new Random().Next(1, 101);
        }
    }
    return numbers;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int SumRows(int[,] array, int i)
    {
        int sum = array[i, 0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        return sum;
    }

Console.Write("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
if (rows == colums)
{
    int[,] array = RandFillTwoDimArray(rows, colums);
    PrintArray(array);
    int minSum = 1;
    int sum = SumRows(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        if (sum > SumRows(array, i))
        {
            sum = SumRows(array, i);
            minSum = i + 1;
        }
    }
    Console.WriteLine($"\nСтрока c наименьшей суммой элементов: { minSum}");
}
else
{
    Console.WriteLine("Массив не является прямоугольным. Число строк, не равно числу столбцов.");
}