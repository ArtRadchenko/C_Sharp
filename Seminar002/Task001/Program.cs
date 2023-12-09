// Напишите программу которая берет случайное число из отрезка 10-99 и выводин наибольшую цифру из него.
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