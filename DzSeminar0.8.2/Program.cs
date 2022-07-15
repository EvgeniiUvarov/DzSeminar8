// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Массив A:
// 6 0 2
// 0 4 8
// 0 7 9
// Массив В:
// 0 0 3
// 5 0 4
// 8 2 0
// Результат
// 16 4 18
// 84 16 16
// 107 18 28

using System;
using static System.Console;
Clear();

Write("Введите размер матрицы через пробел: ");

string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[0]);

int[,] firstArray = GetArray(m, n);
PrintArray(firstArray);

WriteLine();
int[,] secondArray = GetArray(n,m);
PrintArray(secondArray);

WriteLine();
WriteLine("Результат: ");
int[,] resultMatric = GetArray(m,n);
arrSum(firstArray, secondArray, resultMatric);
PrintArray(resultMatric);


void arrSum(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for (int i = 0; i < resultMatric.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatric.GetLength(1); j++)
        {
            int sum = 0;
           for (int z = 0; z < firstArray.GetLength(1); z++)
           {
            sum += firstArray[i,z] * secondArray[z,j];
           }
           resultMatric[i,j] = sum;
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