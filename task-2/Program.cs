Console.Write("Ввведите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x>y) Console.Write($"Число {x} больше числа {y}");
else if (y>x) Console.Write($"Число {y} больше числа {x}");
else Console.Write("Числа равны");