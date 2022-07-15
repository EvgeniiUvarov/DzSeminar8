// Заполните спирально массив 4 на 4
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

using System;
using static System.Console;
Clear();

Write("Введите размер матрицы: ");
int sizeS = int.Parse(ReadLine());
int[,] speral = GetArraySpiral(sizeS);
WriteLine();

PrintArray(speral);

int[,] GetArraySpiral(int size)
{
    int[,] result = new int[size, size];
    int number = 1;

    for (int i = 0; i < size / 2; i++)
    {
        for (int j = i; j < size - i; j++)
        {
            result[i, j] = number++;
        }
        for (int k = i + 1; k < size - i; k++)
        {
            result[k, size - 1 - i] = number++;
        }
        for (int j = size - i - 2; j >= i; j--)
        {
            result[size - 1 - i, j] = number++;
        }
        for (int k = size - 2 - i; k > i; k--)
        {
            result[k, i] = number++;
        }
    } 
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}