//Задача 66. Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

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

int sum = 0;
int GetNumbers(int m, int n)
{
    if (m <= n)
    {
        sum += m;
        m++;
        GetNumbers(m, n);
    }
    return sum;
}

Console.WriteLine(GetNumbers(m, n));