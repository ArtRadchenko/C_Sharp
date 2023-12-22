// Задать массив из символов (тип char []). Создайте строку из символов этого массива.
// Конструктор вида string (char []) не использовать. Пример ['a', 'b', 'c', 'd'] => "abcd"

using System.Text;

char[] array = {'a', 'b', 'c', 'd'};
StringBuilder strB = new StringBuilder();
for (int i = 0; i < array.Length; i++)
{
    strB.Append(array[i]);
}
System.Console.WriteLine(strB.ToString());