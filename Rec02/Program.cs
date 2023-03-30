/*
Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


using System;
using static System.Console;
Clear();

int Prompt(string message)
{
    Write(message);
    int num = int.Parse(ReadLine()!);
    return num;
}

int SumNumbers(int start, int end)
{
    if (start == end) return start;
    return (start + SumNumbers(start + 1, end));
}

int m = Prompt("Enter M: ");
int n = Prompt("Enter N: ");

WriteLine($"Sum is {m} -> {n} = {SumNumbers(m, n)}");
