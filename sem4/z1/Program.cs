//Задача 24: Напишите программу, которая
//принимает на вход число (А) и выдаёт сумму чисел
//от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

Console.WriteLine("введите целое положительное число");
int num = Convert.ToInt32(Console.ReadLine());
//int num1 = int.Parse(Console.Readline());
//int sum = 0;
//for (int i = 1; i <= num; i++)
//{
//    sum = sum + i; //sum += i;
//}
//Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");

int sumNumbers = SumNumbers(num);
Console.WriteLine($"Сумма чисел от 1 до {num} = {sumNumbers}");

int SumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        checked // ШОБ НЕ ВЫДАЛ НЕПРАВИЛЬНОЕ ЗНАЧЕНИЕ, А ОШИБКУ.
        {
            sum = sum + i; //sum += i;
        }
    }
    return sum;
}

