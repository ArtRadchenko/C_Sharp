//Напишите программу, которая на вход принимает два целых числа и выдает его квадрат (число умноженное само на себя).

System.Console.Write("Enter number: ");
string str = Console.ReadLine();
int num = Convert.ToInt32(str);

int square = num * num;

System.Console.WriteLine($"square = {square}");