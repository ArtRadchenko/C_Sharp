// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
int[,] RandomFillArray(int colums, int rows, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < colums; l++)
        {
            array[i,l] = rand.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int SumNumber(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            if (i == l)
            {
                sum = sum + array[i,l];
            }
        }
    }
    return sum;
}

int[,] list = RandomFillArray(5, 5, 0, 10);
PrintArray(list);
int sum = SumNumber(list);
Console.WriteLine();
Console.WriteLine(sum);