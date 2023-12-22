// Обратная строка: Создайте программу, которая примет строку и выведит ее в обратном порядке.
string GetString()
{
    Console.WriteLine("Введите строку: ");
    string str = Console.ReadLine();
    return str;
}

string ReturnString(string str)
{
    string result = String.Empty;
    for (int i = str.Length-1; i >= 0; i--)
    {
        result += str[i];
    }
    return result;
}

string str = GetString();
string rev = ReturnString(str);
Console.WriteLine(rev);