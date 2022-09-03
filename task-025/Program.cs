Console.Write("Введите значение x: ");
bool isNum_x = int.TryParse(Console.ReadLine(), out int x);

Console.Write("Введите значение степени: ");
bool isNum_y = int.TryParse(Console.ReadLine(), out int y);

if (!isNum_x || !isNum_y || y < 0)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

int GetDegree(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    return result;
}

Console.Write(GetDegree(x, y));