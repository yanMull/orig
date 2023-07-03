/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
using System;
using static System.Console;
int[,] matrix = new int[3, 4];
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Write($"{matr[i, j]} ");
        }
        WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
    return;
}

void NumIndex(int[,] matr)
{
    WriteLine("введите индекс строки");
    int num1 = int.Parse(ReadLine());
    WriteLine("введите индекс столбца");
    int num2 = int.Parse(ReadLine());
    if (num1 < matr.GetLength(0) && num2 < matr.GetLength(1))
    {
        WriteLine(matr[num1 - 1, num2 - 1]);
    }
    else WriteLine(" такого числа в массиве нет");
}
FillArray(matrix);
NumIndex(matrix);
PrintArray(matrix);
