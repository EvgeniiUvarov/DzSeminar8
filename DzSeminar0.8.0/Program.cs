// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Исходный массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Результат:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using static System.Console;
Clear();

Write("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);

int[,] sortArray = GetArray(m,n);
PrintArray(sortArray);

WriteLine();

SortsortArray(sortArray);
PrintArray(sortArray);


void SortsortArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(1) -1; z++)
            {
                if (array[i,z] < array[i,z + 1])
                {
                    int temp = array[i,z + 1];
                    array[i,z + 1] = array[i,z];
                    array[i,z] = temp;
                }
            }
        }
    }
}    

int[,] GetArray(int m, int n)
{
    int[,] result =  new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j] = new Random().Next(1,10);
        }
    }
    return result;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i,j]} ");
        }
        WriteLine();
    }
}