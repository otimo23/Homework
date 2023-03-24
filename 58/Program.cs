/*  Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49  */

using System;
using static System.Console;
Write("Enter rows number: ");
int row = int.Parse(ReadLine()!);
Write("Enter column number: ");
int column = int.Parse(ReadLine()!);
int [,]array1 = GetArray(row, column, 1, 10);
int [,]array2 = GetArray(row, column, 1, 10);
PrintArray(array1);
WriteLine();
PrintArray(array2);
WriteLine();
PrintArray(Multiplicacion(array1, array2));



int[,] GetArray(int m, int n, int min, int max )
{
    int[,]result = new int [m,n];
    for(int i=0; i<m;i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j] = new Random().Next(min,max);
        }
    }
    return result;
}
void PrintArray(int [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1);j++)
        {
            Write ($"{array[i,j]+ " "}");
        }
        WriteLine ();
    }
}
int[,] Multiplicacion(int[,] array1, int[,] array2)
{
    int k = array1.GetLength(0);
    int l = array1.GetLength(1);
    int[,] result = new int[k, l];
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < l; j++)
        {

            result[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return result;
}
