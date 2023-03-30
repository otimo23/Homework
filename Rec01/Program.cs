/*  Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"  */

using System;
using static System.Console;
Clear();


int Prompt(string message)
{
    Write(message);
    int result = int.Parse(ReadLine()!);
    return result;
}

string PrintStringNum(int num, int firstnum)
{
    if (firstnum == num) return firstnum.ToString();
    return (firstnum + " " + PrintStringNum(num, firstnum - 1));
}

int m = 1;
int n = Prompt("Enter number N: ");

WriteLine($"Natural numbers: {PrintStringNum(m, n)}");

