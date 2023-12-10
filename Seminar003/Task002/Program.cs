// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. Замените отрицательные элементы на положительные, а положительные на отрицательные.

void FillArray(int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-10, 10);
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
void PositivArray(int[] pos)
{
    for(int i = 0; i < pos.Length; i++)
    {
        pos[i] *= -1;
    }
}


int[] list = new int[10];
FillArray(list); 
PrintArray(list);
PositivArray(list);
Console.WriteLine();
PrintArray(list);

