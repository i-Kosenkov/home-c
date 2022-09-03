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
        array[i] = random.Next(0, 100);
    }
    return array;
}

//Печать массива
void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
}

int GetSumNumber(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        result = result + array[i];

    }
    return result;
}

int[] randomArray = GetRandomArray(x);
PrintArray(randomArray);
Console.WriteLine();
Console.WriteLine($"Сумма нечетных: {GetSumNumber(randomArray)}");

