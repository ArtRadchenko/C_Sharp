//Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, состоящий из средних арифметических значений по строкам двумерного массива.

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

int[,] array = RandomFillArray(5, 5, 0, 10);
int[] arr_01 = new int[array.GetLength(0)];
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }
    arr_01[i] = sum/array.GetLength(1);
}
Console.WriteLine($"[{String.Join(", ", arr_01)}]");