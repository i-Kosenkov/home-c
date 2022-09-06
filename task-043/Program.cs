//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1: ");
bool isNum_b1 = double.TryParse(Console.ReadLine(), out double b1);
Console.Write("Введите k1: ");
bool isNum_k1 = double.TryParse(Console.ReadLine(), out double k1);
Console.Write("Введите b2: ");
bool isNum_b2 = double.TryParse(Console.ReadLine(), out double b2);
Console.Write("Введите k2: ");
bool isNum_k2 = double.TryParse(Console.ReadLine(), out double k2);

if (!isNum_b1 || !isNum_k1 || !isNum_b2 || !isNum_k2)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

double[] GetConnectPoint(double x1, double y1, double x2, double y2)
{
double [] array = new double[2];
array[0] = (x2 - x1) / (y1 - y2);
array[1] = y2 * ((x2 - x1) / (y1 - y2)) + x2;
return array;
}

double[] array = GetConnectPoint(b1,k1,b2,k2);

Console.Write($"Точка пересечения прямых ({array[0]}, ");
Console.Write($"{array[1]})");
