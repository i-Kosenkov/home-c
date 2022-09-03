Console.Write("Введите размер массива: ");
bool isNum_x = int.TryParse(Console.ReadLine(), out int x);
if (!isNum_x)
{
    Console.Write("Ошибка ввода");
    return;
}

int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

int GetEvenNumber(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result = result + 1;
        }
    }
    return result;
}

int[] array = GetRandomArray(x);

foreach (int item in array)
    {
        Console.Write($"{item} ");
    }

Console.WriteLine();
Console.Write("Количество четных числе: ");
Console.WriteLine(GetEvenNumber(array));