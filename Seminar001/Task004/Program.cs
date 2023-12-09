// Напишите программу которая на вход принимает целое число N, а на выходе показывает все целые числа от -N до N.

Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
int num = Convert.ToInt32(str);
int numStart = -num;
while(numStart <= num)
{
    Console.WriteLine($"{numStart}");
    ++numStart;
}