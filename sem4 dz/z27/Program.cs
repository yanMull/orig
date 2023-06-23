Console.Write("enter number:");
int a = Convert.ToInt32(Console.ReadLine());
int b = SumNum(a);
int SumNum(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
Console.WriteLine($"sum number {a} = {b}");