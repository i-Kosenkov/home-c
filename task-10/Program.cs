int RandomNumber()
{
    int NumberX = new Random().Next(100, 1000);
    return NumberX;
}

int MiddleNumber(int NumberZ)
{
    NumberZ = (NumberZ % 100) / 10;
    return NumberZ;
}

Console.Write("Подобрать случайное число (да/нет)? ");
string YesNo = Console.ReadLine();
if (YesNo.ToLower() == "да")
{
    int x = RandomNumber();
    Console.WriteLine(x);
    Console.WriteLine($"Вторая цифра числа: {MiddleNumber(x)}");
}
else
{
    Console.Write("Введите трехзначное число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Вторая цифра числа: {MiddleNumber(x)}");
}