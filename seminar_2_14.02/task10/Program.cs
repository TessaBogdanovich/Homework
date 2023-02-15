// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();

int showSecondDigit(int number)
{
    int firstTwoDigit = number / 10;
    int secondDigit = firstTwoDigit % 10;
    return secondDigit;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    Console.WriteLine("Числое не является трёхзначным.");
    return;
}
int result = showSecondDigit(number);
Console.WriteLine(result);
