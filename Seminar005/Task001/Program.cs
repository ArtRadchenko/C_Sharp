// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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

void FindIndex(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
}
int[,] array = RandomFillArray (5, 5, 1, 10);
PrintArray(array);
Console.WriteLine();
FindIndex(array);
PrintArray(array);