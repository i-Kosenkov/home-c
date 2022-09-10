//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

//Рандомно заполнить двумерный массив
void GetRandomDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

//печать двумерного массива
void PrintDoubleArray(double[,] array)
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

//Печать массива
void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        Console.Write($"{item} ");
    }
}

//Среднее арифметическое строк
double[] GetAverage(double[,] array)
{
    double[] result = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        result[i] = sum / array.GetLength(1);
    }
    return result;
}

double[,] array = new double[3, 4];
GetRandomDoubleArray(array);
PrintDoubleArray(array);
double[] resultArray = GetAverage(array);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(resultArray);