// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру из этого числа.
int number = new Random().Next(100, 1000);
int num1 = number / 100; 
int num2 = number % 10;
int result = num1 * 10 + num2;
Console.WriteLine($"Случайное число: {number}");
Console.WriteLine($"Результат: {result}");