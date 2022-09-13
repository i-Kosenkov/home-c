//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

//Сортировка строк двухмерного массива
int[,] GetSortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int minPosition = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, minPosition]) minPosition = k; //Меняя < > получаем разные сортировки
            }
            int temporary = array[i, j];
            array[i, j] = array[i, minPosition];
            array[i, minPosition] = temporary;

        }
    }
    return array;
}

int[,] array = new int[3, 7];
GetRandomDoubleArray(array);
PrintArray(array);
Console.WriteLine();
int[,] newArray = GetSortArray(array);
PrintArray(newArray);
