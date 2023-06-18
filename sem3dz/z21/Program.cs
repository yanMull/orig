Console.WriteLine("Enter num");
int n = int.Parse(Console.ReadLine());
int i = 1;
if (n<i)
{Console.WriteLine("Error n");
return;
}
while(i<=n)
{
    Console.Write($" {Math.Pow(i,3)}");
    i++;
}
Console.WriteLine("");
