// На основе символьной строки (тип String) сформировать массив символов (тип char []) и вывести на экран.
// Пример "Hello!" = ['H', 'e', 'l', 'l', 'o', '!']
string str = "Hello!";
char[] array = new char[str.Length];
for (int i = 0; i < str.Length; i++)
{
    array[i] = str[i];
}
Console.Write('[');
for (int j = 0; j < array.Length; j++)
{
    Console.Write($"'{array[j]}', ");
}
Console.Write(']');