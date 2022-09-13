//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

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

//Произведение матриц 
int[,] GetMatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix3;
}

int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 3];

// int[,] matrix1 = new int[2,2] {{ 2, 4}, {3, 2 }};
// int[,] matrix2 = new int[2,2] {{ 3, 4}, {3, 3 }};

GetRandomDoubleArray(matrix1);
PrintDoubleArray(matrix1);
Console.WriteLine();
GetRandomDoubleArray(matrix2);
PrintDoubleArray(matrix2);
if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Матрицы нельзя пермножить так как число столбцов матрицы 1 не равно числу строк матрицы 2");
    return;
}
Console.WriteLine();
PrintDoubleArray(GetMatrixMultiplication(matrix1, matrix2));

