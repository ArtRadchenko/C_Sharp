// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];

void RandDobFillArray(int size)
{
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.NextDouble();
        Console.Write($"{array[i]:F2} ");
    }
}

double DiffDobElArray(double[] array)
{
    double min = array[0];
    double max = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
        i = i + 1;
    }
    return min - max;
}

RandDobFillArray(size);
Console.Write($"\nРазница: {DiffDobElArray(array):F2} ");