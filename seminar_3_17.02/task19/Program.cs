// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
bool Num(int a)
{
  int t = a;
  int b = 0;
  while (a > 0)
{
  int o = a % 10;
  a = a / 10;
  b = b * 10 +0;
}
bool f = t == b;
return f;
}
bool m = NewMethod();
System.Console.WriteLine(m);

bool NewMethod()
{
    bool m = Num(12321);
    return m;
}