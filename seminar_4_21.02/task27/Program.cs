// Задача 27: Напишите метод, который принимает на вход число и 
// выдаёт сумму цифр в числе.
//452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt (string message)
{
string ReadinPut = Console.ReadLine();
int result = int.Parse(ReadinPut);
return result;
}

int sumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
result += number % 10;
number = number / 10;
    }
     return result;
}
int number = Prompt("Введите число: ");
Console.WriteLine($"Сумма всех чисел в цифре: {number} = {sumAllDigit(number)}");

