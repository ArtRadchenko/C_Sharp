//Напишите программу которая будет выдавать название дня недели по заданному номеру.

Console.Write("Enter week day (1-7): ");
string weekDay = Console.ReadLine();
int numWeekDay = Convert.ToInt32(weekDay);
if(numWeekDay == 1)
{
    Console.WriteLine("Monday");
}
else if(numWeekDay == 2)
{
    Console.WriteLine("Tuesday");
}
else if(numWeekDay == 3)
{
    Console.WriteLine("Wednesday");
}
else if(numWeekDay == 4)
{
    Console.WriteLine("Thursday");
}
else if(numWeekDay == 5)
{
    Console.WriteLine("Friday");
}
else if(numWeekDay == 6)
{
    Console.WriteLine("Saturday");
}
else if(numWeekDay == 7)
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("uncorect week day");
}