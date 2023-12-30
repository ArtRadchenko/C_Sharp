// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void PrintArray(int[] array, int index = 0)
{
    if (index != array.Length)
    {
        PrintArray(array, index + 1);
        Console.Write($"{array[index]} ");
    }
}

int[] array = new int[] {1, 2, 3, 4, 5};
PrintArray(array);