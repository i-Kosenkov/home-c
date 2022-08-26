Console.WriteLine("Введите координаты точки А:");
bool isNum_x1 = int.TryParse(Console.ReadLine(), out int x1);
bool isNum_y1 = int.TryParse(Console.ReadLine(), out int y1);
bool isNum_z1 = int.TryParse(Console.ReadLine(), out int z1);

Console.WriteLine("Введите координаты точки B:");
bool isNum_x2 = int.TryParse(Console.ReadLine(), out int x2);
bool isNum_y2 = int.TryParse(Console.ReadLine(), out int y2);
bool isNum_z2 = int.TryParse(Console.ReadLine(), out int z2);

double GetDistance(int a1, int b1, int c1, int a2, int b2, int c2)
{
    double result = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2) + Math.Pow((c2 - c1), 2));
    return result;
}

Console.Write($"Расстояние между точка А и Б: {GetDistance(x1,y1,z1,x2,y2,z2)}");