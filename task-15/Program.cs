string WeekDays(int NumberDay)
{
    switch (NumberDay)
    {
        case 1: return "понедельник";
        case 2: return "вторник";
        case 3: return "среда";
        case 4: return "четверг";
        case 5: return "пятница";
        case 6: return "суббота";
        case 7: return "воскресенье";
        default: return "неверное значение";
    }
}

Console.Write ("Введите цифрой день недели: ");
int x = Convert.ToInt32(Console.ReadLine());
string Day = WeekDays(x);
Console.Write ($"День недели: {Day}");