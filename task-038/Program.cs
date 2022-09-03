Console.Write("Введите размер массива: ");
bool isNum_x = int.TryParse(Console.ReadLine(), out int x);
if (!isNum_x || x <= 1)
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
        array[i] = random.Next(-100, 100);
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

int GetMinNumber(int[] array)
{
    int result = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < result) result = array[i];
    }
    return result;
}

int GetMaxNumber(int[] array)
{
    int result = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > result) result = array[i];
    }
    return result;
}

int[] randomArray = GetRandomArray(x);
PrintArray(randomArray);
Console.WriteLine();
int different = GetMaxNumber(randomArray) - GetMinNumber(randomArray);
Console.WriteLine($"max - min = {different}");