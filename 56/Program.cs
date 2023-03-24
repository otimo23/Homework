/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку
 с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт
 номер строки с наименьшей суммой элементов.*/


using System;
using static System.Console;
Write("Enter rows number: ");
int row = int.Parse(ReadLine()!);
Write("Enter column number: ");
int column = int.Parse(ReadLine()!);
int [,]array = GetArray(row, column, 0, 10);
PrintArray(array);
WriteLine($"The row with  min sum {GetMinSum(array)}");


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
int GetMinSum (int [,] array)
{
    int sum = 0;
    int minsum = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minsum || minsum == 0)
        {
            minsum = sum;
            sum = 0;
            result = i + 1;
        }
    }
    return result;
}
