﻿/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

using System;
using static System.Console;
Write("Enter rows number: ");
int row = int.Parse(ReadLine()!);
Write("Enter column number: ");
int column = int.Parse(ReadLine()!);
int [,]array = GetArray(row, column, 0, 10);
PrintArray(array);
PrintArray(SortArray(array));

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

int [,] SortArray (int [,] array)
{
    for(int i=0; i < array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1)-1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
            
        }
    }
    return array;
}

