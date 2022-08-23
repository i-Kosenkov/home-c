int NumberThree(int z)
{
    if (z < 100) //Проверям есть ли третья цифра в введенном числе
    {
        return -1;
    }

    int n = 0;
    int Number = z;
    while (Number > 0) //Ищем количество цифр в числе, чтобы потом создать массив
    {
        Number = Number / 10;
        n++;
    }

    int[] array = new int[n]; //Создаем массив длинной равной количеству цифр в числе
    int IndexNumberThree = n - 3; //Находим номер индекса в массиве третьего числа. В массив числа будут записываться в обратном порядке.
    int index = 0;
    while (z > 0) //Наполняем массив числами
    {
        array[index] = z;
        z = z / 10;
        index++;
    }
    return (array[IndexNumberThree] % 10);//Так как в массив записалось число с тремя цифрами, ищем остаток от деления на 10 (это и есть число №3)
}

Console.Write("Введите любое число: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = NumberThree(x);
if (y == -1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третьей цифра числа: {y}");
}