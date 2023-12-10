// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
Console.WriteLine("Введите координату X:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0) {Console.WriteLine("Первая четверть");}
if(x < 0 && y > 0) {Console.WriteLine("Вторая четверть");}
if(x < 0 && y < 0) {Console.WriteLine("Третья четверть");}
if(x > 0 && y < 0) {Console.WriteLine("Четвертая четверть");}