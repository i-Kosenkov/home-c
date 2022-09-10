//Задача 50. Напишите программу, которая на вход принимает число и ищет в двумерном массиве,
//и возвращает индексы этого элемента или же указание, что такого элемента нет.

//Заполнить двумерный массив
void GetRandomDoubleArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

//печать двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] FindNumber(int number, int[,] array)
{
    int[] result = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (number == array[i, j])
            {
                result[0] = i;
                result[1] = j;
                return result;
            }
        }
    }
    result[0] = -1;
    return result;
}

int[,] array = new int[3, 4];
GetRandomDoubleArray(array);
PrintArray(array);
Console.Write("Введите искомое значение: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] resultArray = FindNumber(x, array);
if (resultArray[0] == -1)
{
    Console.Write("нет такого элемента");
}
else
{
    Console.Write($"Адрес значения: ({resultArray[0]}, {resultArray[1]})");
}
