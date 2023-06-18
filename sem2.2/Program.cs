// 16 Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

Console.Clear();
Console.WriteLine("Напишите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int num2 = int.Parse(Console.ReadLine());
if( num1 * num1 == num2 || num2 * num2 == num1 ) Console.WriteLine("true");
else Console.WriteLine("false");
