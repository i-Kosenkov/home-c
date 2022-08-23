int RandomNumber()
{
    int NumberX = new Random().Next(100, 1000);
    return NumberX;
}

Console.Write("Подобрать случайное число (да/нет)? ");
string YesNo = Console.ReadLine();
if (YesNo.ToLower() == "да")
{
    int x = RandomNumber();
    Console.WriteLine(x);
    Console.WriteLine($"Вторая цифра числа: {(x % 100)/10}");
}
else
{
    Console.Write("Введите трехзначное число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Вторая цифра числа: {(x % 100)/10}");
}