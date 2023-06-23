Console.Write("enter 2 numbers:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int n = Dergee(a, b);
int Dergee(int num, int der)
{
    int i = 1;
    int s = 1;
    while( i <= der)
    {
        s *= num;
        i++;
    }
    return s;
}
Console.Write(n);