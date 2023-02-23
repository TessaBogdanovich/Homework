// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
//  использовать Math.Pow
// 3, 5 -> 243 
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());
RiseToDegree( a, b);

void RiseToDegree(int a, int b)
{
    int deg = 1;
    for (int i = 1; i <= b; i++)
    {
        deg = deg * a;
    }
    Console.WriteLine($"Число А в натуральной степени В : {deg}");
}

