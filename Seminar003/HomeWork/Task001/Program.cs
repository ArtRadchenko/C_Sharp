// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90]

int[] RandomFillArray(int num)
{
    int[] numbers = new int[num];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 100);
    }
    return numbers;
}

bool IsCheck(int num)
{
    return ((num > 19) && (num < 91));
}

int GetCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsCheck(array[i]))
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] list = RandomFillArray(size);
PrintArray(list);
Console.WriteLine();
Console.Write("Ответ: ");
Console.WriteLine(GetCount(list));