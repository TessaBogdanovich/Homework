NewMethod();

static void NewMethod()
{
    int[,] array = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

    Console.WriteLine("Введите номер строки:");

    int row = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите номер столбца:");

    int col = Convert.ToInt32(Console.ReadLine());

    if (row < 0 || row > array.GetLength(0) - 1 || col < 0 || col > array.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент отсутствует");
    }
    else
    {
        Console.WriteLine($"Значение элемента:{array[row, col]}");
    }
}

