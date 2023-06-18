Console.WriteLine ("enter num: ");
int n = int.Parse(Console.ReadLine()!);
int a = n%10;
int b = n%100/10;
int c = n/10000;
int d = n/1000%10;
if (a == c) {
    if (b == d) Console.WriteLine ("yes");
} 
else Console.WriteLine ("no");