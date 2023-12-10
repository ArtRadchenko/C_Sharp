// Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новый массив.
int[] list = {2, 4, 5, 6, 7, 9};
void multiArray(int[] array)
{
    int[] mass = new int[array.Length/2];
    for(int i = 0; i < array.Length/2; i++)
    {
        mass[i] = array[i]*array[array.Length-1-i];
        Console.WriteLine(mass[i]+" ");
    }
}
multiArray(list);