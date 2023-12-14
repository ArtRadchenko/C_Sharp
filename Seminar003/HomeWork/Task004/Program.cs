// Задача 4: Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int number = new Random().Next(1, 100001);
Console.Write($"Дано число: {number}");
int num = number;
int size = 0;
if (num == 0) size = 1;
while (num != 0)
{
    num /= 10;
    size++;
}
Console.Write($"\nДлина массива: {size}");

int[] array = new int[size];
for (int i = size - 1; i >= 0; i--)
{
    array[i] = number % 10;
    number /= 10;
}

System.Console.Write("\nМассив из цифр введённого числа: ");
PrintArray(array);