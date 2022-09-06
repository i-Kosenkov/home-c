//Заполянем массив рандомными числами
int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 100);
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

//Проверка вводимого числа 
Console.Write("Введите длину массива: ");
bool isNum_x = int.TryParse(Console.ReadLine(), out int x);
if (!isNum_x || x <= 0)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

//Считаем сколько положительных чисел в массиве
int GetPositiveNumber(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }
    return result;
}

int[] randomArray = GetRandomArray(x);
PrintArray(randomArray);
Console.WriteLine();
Console.WriteLine($"Положительных чисел: {GetPositiveNumber(randomArray)}");

