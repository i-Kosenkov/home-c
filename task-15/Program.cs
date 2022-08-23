string WeekDays(int NumberDay)
{
    switch (NumberDay)
    {
        case 1: return "нет - понедельник";
        case 2: return "нет - вторник";
        case 3: return "нет - среда";
        case 4: return "нет - четверг";
        case 5: return "нет - пятница";
        case 6: return "да - суббота";
        case 7: return "да - воскресенье";
        default: return "Ввели неверное числовое значение";
    }
}

Console.Write("Введите день недели числом: ");
int x = Convert.ToInt32(Console.ReadLine());
string Day = WeekDays(x);
Console.Write($"День недели выходной? {Day}");