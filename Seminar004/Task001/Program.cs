// Задайте одномерный массив, заполненный случайными числами. Определите количество простых чисел в этом массиве. Примеры [1 3 4 19 3] => 2 [4 3 4 1 9 5 21 13]  => 3
int[] list = new int[10];
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
FillArray(list);
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
PrintArray(list);
bool IsPrime(int num)
{
    for(int i = 2; i < num; i++)
    {
        if(num % i == 0)
        {
            return false;
        }
    }
    return true;
}
int GetCountPrimeNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(IsPrime(array[i]))
        {
            count++;

        }
    }
    return count;
}
Console.WriteLine();
Console.WriteLine(GetCountPrimeNumber(list));