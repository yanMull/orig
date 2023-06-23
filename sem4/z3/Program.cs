Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int factNumber = Factorial(number);
Console.WriteLine(factNumber);
int Factorial(int num)
{
    int fact = 1;
    for (int i = 2; i < num; i++)
    {
        fact *= i;
    }
    return fact;
}

//Задача 28: Напишите программу, которая
//принимает на вход число N и выдаёт
//произведение чисел от 1 до N. 
//4 -> 24
//5 -> 120