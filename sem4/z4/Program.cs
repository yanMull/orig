﻿//Задача 30: Напишите программу, которая
//выводит массив из 8 элементов, заполненный
//нулями и единицами в случайном порядке.
//[1,0,1,1,0,1

int[] array = new int[8];
FillArray(array);
PrintArray(array);
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Lenght; i++)
    {
        arr[i] = new Random().Next(2);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}