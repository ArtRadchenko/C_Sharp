// Считать строку с консоли, состоящую из латинских букв в нижнем регистре.
// Выяснить, сколько среди введенных букв гласных.
bool IsVowel(char c)
{
    string vowels = "aeouy";
    return vowels.Contains(c);
}

string GetString()
{
    Console.WriteLine("Введите строку: ");
    string str = Console.ReadLine();
    return str;
}

int CountVowels(string str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (IsVowel(str[i])) count++;
    }
    return count;
}

string str = GetString();
int vowel = CountVowels(str);
Console.WriteLine($"Количество гласных {vowel}");