//Добавил возможность выбора числа (в ручную/рандом)

int RandomNumber() //Метод рандомного числа
{
    int NumberX = new Random().Next(100, 1000);
    return NumberX;
}

int SecondNumber(int Number) //Метод второй цифры в числе
{
    if (Number < 1000 && Number >= 100)
    {
    Number = (Number % 100) / 10;
    return Number;
    }
    else
    {
    return -1;    
    }
}

Console.Write("Подобрать случайное число (да/нет)? ");
string YesNo = Console.ReadLine();
if (YesNo.ToLower() == "да")
{
    int x = RandomNumber();
    Console.WriteLine($"Случайное число: {x}");
    Console.WriteLine($"Вторая цифра числа: {SecondNumber(x)}");
}
else
{
    Console.Write("Введите трехзначное число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (SecondNumber(x) == -1)
    {
Console.WriteLine($"Введено не трехзначное число: {x}");
    }
    else
    {
    Console.WriteLine($"Вторая цифра числа: {SecondNumber(x)}");
    }
}