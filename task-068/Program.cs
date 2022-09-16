//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

//Проверка вводимого числа 
Console.Write("Введите число M: ");
bool isNum_m = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите число N: ");
bool isNum_n = int.TryParse(Console.ReadLine(), out int n);
if (!isNum_m || !isNum_n)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

int GetAkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return GetAkkermanFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return GetAkkermanFunction(m - 1, GetAkkermanFunction(m, n - 1));
    }
    return 0;
}
Console.WriteLine(GetAkkermanFunction(m, n));