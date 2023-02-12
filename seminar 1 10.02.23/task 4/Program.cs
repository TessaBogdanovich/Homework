
int a = 3;
int b = 5;
int c = 7;

int max = a;
if (b > a)
{
    max = b;
}
if (c > max)
    max = c;

Console.WriteLine(max);
