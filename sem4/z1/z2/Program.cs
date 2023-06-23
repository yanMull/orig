//Задача 26: Напишите программу, которая принимает
//на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5
Console.WriteLine("введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
//int i = 0;
//while (n != 0)
//{
//    n = n / 10;
//    i++;
//}
//Console.WriteLine(i);
int res = Result(n);
Console.WriteLine(res);
int Result(int num)
{
    int index = 0;
    while (n != 0)
    {
        n = n / 10;
        index++;
    }
    return index;
}