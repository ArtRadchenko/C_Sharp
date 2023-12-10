// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. Программа должна выдать ответ: Да/Нет.
Console.WriteLine("Введите число");
int[] array = new int[10];
int number = Convert.ToInt32(Console.ReadLine());

void FillArray(int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

FillArray(array);
PrintArray(array);

bool FindNumber(int num, int[] list)
{
    for(int i = 0; i < list.Length; i++)
    {
        if  (num == list[i])
        {
            return true;
        }
    }
    return false;
}

if (FindNumber(number, array))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}