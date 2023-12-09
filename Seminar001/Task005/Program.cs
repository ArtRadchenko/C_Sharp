// Напишите программу которая на вход принимает трехзначное число, а на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
int num = Convert.ToInt32(str);
if(num > 99 && num < 1000)
{
    int num2 = num % 10;
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine("A non-three-digit number was entered");
}