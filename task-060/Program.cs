//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//Заполнить рандомно трехмерный массив
void GetRandomTrippleArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
                while (!GetDoubleAllert(array, array[i, j, k]))
                {
                    array[i, j, k] = new Random().Next(10, 100);
                }
            }
        }
    }
}

//Проверка чисел на дубли
bool GetDoubleAllert(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

//печать трехмерного массива
void PrintTrippleArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array = new int[3, 3, 3];
if (array.GetLength(0) * array.GetLength(1) * array.GetLength(2) > 99)
{
    Console.WriteLine("Массив слишком большой, не получится подобрать все различные значения");
    return;
}
GetRandomTrippleArray(array);
PrintTrippleArray(array);