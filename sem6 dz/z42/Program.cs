 /*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("введите k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите k2");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите b2");
int b2 = Convert.ToInt32(Console.ReadLine());
if (k1==k2)
{
    Console.WriteLine("линии не пересекутся");
    return;
}
int x =(b1-b2)/(k1-k2);
int y = k1*x+b1;
Console.WriteLine($"x = {x}, y = {y}");