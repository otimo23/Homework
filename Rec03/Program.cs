/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

using System;
using static System.Console;
Clear();

int Prompt(string message)
{
    Write(message);
    int num_result = int.Parse(ReadLine()!);
    return num_result;
}

int FunctionAk(int mAk, int nAk)
{
    if (mAk == 0) return nAk + 1;
    if (nAk == 0) return FunctionAk(mAk - 1, 1);
    return FunctionAk(mAk - 1, FunctionAk(mAk, nAk - 1));
}

int m = Prompt("Enter M: ");
int n = Prompt("Enter N: ");

WriteLine($"m = {m}, n = {n} -> A(m, n) = {FunctionAk(m, n)}");
