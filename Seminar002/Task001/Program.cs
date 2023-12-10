// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.WriteLine("Hello, World!");

int number = GetNumber();
System.Console.WriteLine(number);

int num1 = number / 10;
int num2 = number % 10;

if(num1 > num2)
{
    System.Console.WriteLine(num1);
}
else
{
    System.Console.WriteLine(num2);
}

int GetNumber()
{
    Random rand = new Random();
    int num = rand.Next(10, 100);
    return num;
}