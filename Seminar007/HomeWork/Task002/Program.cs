// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int FunAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0)
        {
            return FunAkkerman(m - 1, 1);
        }
        else
        {
            return FunAkkerman(m - 1, FunAkkerman(m, n - 1));
        }
    }
}

Console.WriteLine($"Функция Аккермана = {FunAkkerman(m, n)}");