Console.Write("Введите значение x: ");
bool isNum_x = int.TryParse(Console.ReadLine(), out int x);

if (!isNum_x || x < 0)
{
    Console.WriteLine("Ошибка ввода");
    return;
}


int GetSum(int a)
{
    int result = 0;
    for (int i = 0; a > 0; i++)
    {
        result = result + a % 10;
        a = a / 10;
    }
    return result;
}

Console.Write(GetSum(x));