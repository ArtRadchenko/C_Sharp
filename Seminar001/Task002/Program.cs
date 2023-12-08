//Напишите программу, которая на вход принимает два целых числа и проверяет, является ли первое число квадратом второго.

Console.Write("Enter number 1: ");
string str1 = Console.ReadLine();
int num1 = Convert.ToInt32(str1);
Console.Write("Enter number 2: ");
string str2 = Console.ReadLine();
int num2 = Convert.ToInt32(str2);
if(num2 * num2 == num1)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}