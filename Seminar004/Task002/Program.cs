// Задайте массив из N случайных целых чисел (N вводится с клавиатуры). Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7. Пример [1 5 11 21 81 4 0 91 2 3] => 2
int[] FillArray2(int num)
{
    int[] numbers = new int[num];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 100);
    }
    return numbers;
}

void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
}

bool IsCheck(int num)
{
    return ((num % 7 == 0) && (num % 10 == 1));
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

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] list = FillArray2(size);
PrintArray(list);
Console.WriteLine();
Console.WriteLine(GetCount(list));