// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(0,1,0) 53(0,1,1)
// 32(1,0,0) 41(1,0,1)
// 66(1,1,0) 88(1,1,1)

using System;
using static System.Console;
Clear();

Write("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[0]);
int s = int.Parse(sizeS[0]);

int[,,] arr = GetArray(m,n,s);
PrintArray(arr);

int[,,] GetArray(int m, int n, int s)
{
    int[,,] result =  new int[m,n,s];
    
    for(int i=0; i < m; i++)
    {
        for(int j=0; j < n; j++)
        {
            for (int z = 0; z < s; z++)
            {
                result[i,j,z] = new Random().Next(9,100);
               
            }
        }
    }
    return result;
}


void PrintArray(int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          for (int z = 0; z < array.GetLength(2); z++)
            {
                Write($"{array[i,j,z]} ");
                Write($"{(i,j,z)} ");
            }
            WriteLine();
        }
    }
}