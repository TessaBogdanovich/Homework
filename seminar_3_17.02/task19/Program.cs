﻿ // Задача 19
    // Напишите программу, которая принимает на вход пятизначное число и проверяет,
    // является ли оно палиндромом.
    // 14212 -> нет
    // 12821 -> да

bool Num(int a);
{
  int a;
  int b = 0;
  while (a > 0)
  {
    int o = a % 10;
    a = a /100;
    b = b*10 + o;
  }
  bool f = t == b;
  return f;
}

bool m = Num(12345);
Console.WriteLine(m);


   