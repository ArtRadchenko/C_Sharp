// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

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
    return (num % 2 == 0);
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

Console.Write("Массив: ");
int size = 10;
int[] list = RandomFillArray(size);
PrintArray(list);
Console.Write("\nОтвет: ");
Console.WriteLine(GetCount(list));