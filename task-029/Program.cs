Console.Write("Введите объем массива: ");
bool isNum_x = int.TryParse(Console.ReadLine(), out int x);

if (!isNum_x || x < 1)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

//Заполняем массив, ЛЮБЫМИ значениями!
string[] GetArray(int lenght)
{
    string[] array = new string[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива:");
        array[i] = Console.ReadLine();
    }
    return array;
}

//Вывод данных из массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PrintArray(GetArray(x));