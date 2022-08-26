Console.Write("Введите значение N: ");
bool isNum_N = int.TryParse(Console.ReadLine(), out int N);

if (!isNum_N || N < 1)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

void GetCube(int X)
{
    for (int i = 1; i <= N; i++)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
    }
}

GetCube(N);