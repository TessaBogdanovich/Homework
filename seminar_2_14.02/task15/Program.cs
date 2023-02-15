// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();

void showHolidays(int number)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Да.");
    }
    else
    {
        Console.WriteLine("Нет.");
    }
}
Console.Write("Введите номер дня недели: ");
int numberDay = Convert.ToInt32(Console.ReadLine());
if (numberDay > 7 || numberDay < 1)
{
    Console.WriteLine("Дня недели с таким номером не существует.");
    return;
}
showHolidays(numberDay);
