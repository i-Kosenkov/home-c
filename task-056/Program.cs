//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Заполнить рандомно двумерный массив
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
void PrintDoubleArray(int[,] array)
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

//Суммируем данные в строках и находим минимальную сумму
int GetSortArray(int[,] array)
{
    int[] sumRows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRows[i] += array[i, j]; //Все суммы строк записываем в массив
        }
    }

    //Находим минимальное значение в массиве (можно было бы в отдельный метод сделать, но не стал :)
    int indexMinRow = 0;
    int minSum = sumRows[0];
    for (int i = 1; i < sumRows.Length; i++)
    {
        if (minSum > sumRows[i])
        {
            indexMinRow = i;
            minSum = sumRows[i];
        }
    }
    return indexMinRow + 1;
}

int[,] array = new int[5, 3];
GetRandomDoubleArray(array);
PrintDoubleArray(array);
Console.WriteLine($"Номер строки с минимальной суммой элементов: {GetSortArray(array)}");