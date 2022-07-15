// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Исходный массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Результат:
// 1-строка

using System;
using static System.Console;
Clear();

Write("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);

int[,] arr = GetArray(m,n);
PrintArray(arr);

WriteLine($"Строка с наименьшей суммой элементов: {arrSum(arr)}");

int arrSum(int[,] array)
{
    int index = 0;
    int minString = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum =0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if(i==0) minString = sum;

        if (minString >= sum) 
        {
            index = i;
            minString = sum;
        }
       
    }
    return index;
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