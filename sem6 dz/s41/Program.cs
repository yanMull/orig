﻿/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

System.Console.WriteLine("M=");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"введите {i+1} число");
    int a = Convert.ToInt32(Console.ReadLine());
    if(a>0) count++;
}
Console.WriteLine($"{count} чисел больше 0");
