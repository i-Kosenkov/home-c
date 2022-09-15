//Напишите программу, которая заполнит спирально массив 4 на 4. 

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

void FillArray(int[,] array)
{
    int n = 11;
    int i = 0;
    int j = 0;
    while (n <= array.GetLength(0) * array.GetLength(1) + 10) //+10 чтобы значения были двухзначные 11, 12, 13....
    {
        array[i, j] = n;
        n++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        {
            j++;
        }
        else if (i < j && i + j >= array.GetLength(0) - 1)
        {
            i++;
        }
        else if (i >= j && i + j > array.GetLength(1) - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
}

int[,] array = new int[5, 5];

if (array.GetLength(0) != array.GetLength(1))
{
    Console.WriteLine("Массив не квадратный");
    return;
}
FillArray(array);
PrintDoubleArray(array);