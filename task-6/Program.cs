Console.Write("Ввведите число для проверки: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x % 2 == 0) Console.Write($"{x} является четным число");
else Console.Write($"{x} является не четным число");