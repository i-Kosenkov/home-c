//Напишите программу, которая заполнит спирально массив 4 на 4. 

int[,] array = new int[4, 6];
int n = 11;
FillArray(0, 0);
PrintDoubleArray(array);

void FillArray(int row, int col)
{
    // Console.WriteLine($"row = {row}");
    // Console.WriteLine($"col = {col}");
    // Console.WriteLine($"n = {n}");
    // Console.WriteLine($"X = {array[row, col]}");
    // Console.WriteLine();

    if (array[row, col] == 0)
    {
        array[row, col] = n;
        n++;

        if (col < array.GetLength(1) - 1)
        {
            FillArray(row, col + 1);
        }

        if (row < array.GetLength(0) - 1)
        {
            FillArray(row + 1, col);
        }

        if (col > 0)
        {
            FillArray(row, col - 1);
        }
        if (row > 0)
        {
            FillArrayUpRow(row - 1, col);
        }
    }
}

void FillArrayUpRow(int row, int col)
{
    // Console.WriteLine($"!row = {row}");
    // Console.WriteLine($"!col = {col}");
    // Console.WriteLine($"!n = {n}");
    // Console.WriteLine($"!X = {array[row, col]}");
    // Console.WriteLine();

    if (array[row, col] == 0)
    {
        array[row, col] = n;
        n++;
        if (row > 0)
        {
            FillArrayUpRow(row - 1, col);
        }
        if (col < array.GetLength(1) - 1)
        {
            FillArray(row, col + 1);
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