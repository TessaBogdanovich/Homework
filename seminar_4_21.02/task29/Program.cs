
        // Задача 29: Напишите метод, который задаёт массив из N элементов 
        // и выводит их на экран.
        // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
        // 6, 1, 33 -> [6, 1, 33]
        
using static Library.Shared;

Author();

void Author()
{
    throw new NotImplementedException();
}

// Напишите метод, который задаёт массив из N элементов и выводит их на экран.
// Создать массив
//  double[] CreateArray(int size){...} +  v

// Заполнить массив руками
//  void Fill(double[] array) + 
//  double[] FillArray(double[] source)

// Распечатать массив
//  void PrintToConsole (double[] array) + 
//  string ArrayJoinToString (double[] array) v

// Считать данные от пользователя
//  double GetDataFromUser (string text) v

// Считать данные от пользователя с целыми числами
//  int GetIntValueFromUser (string text) v


// int count = GetIntValueFromUser("Количество элементов");
// double[] numbers = CreateArray(count);
// Fill(numbers);
// System.Console.WriteLine(ArrayJoinToString(numbers));



// int[] data = { 1, 2, 3, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 1, 1, 1 };

Console.Write("Введите число: ");
int N = 30;
int m = 10;
int[] array = new int[N];
Random rand = new Random();
Console.WriteLine("Исходный массив:");
for (int i = 0; i < array.Length; i++)
{
  array[i] = rand.Next(-3, m);
}

int min = array.Min();

Console.WriteLine(String.Join(' ', array));

// -5 = 5
//  5 = 5

int[] counter = new int[m + Math.Abs(min)];

for (int i = 0; i < array.Length; i++)
{
  counter[array[i] + Math.Abs(min)]++;
}

// Console.WriteLine(String.Join(' ', counter));

// for (int i = 0; i < counter.Length; i++)
// {
//   if (counter[i] != 0)
//     Console.WriteLine($"{i - Math.Abs(min)} {counter[i]}р");
// }


int k = 0;
for (int i = 0; i < counter.Length; i++)
{
  for (int j = 0; j < counter[i]; j++)
  {
    array[k] = i - Math.Abs(min);
    k++;
    //Console.Write(i - Math.Abs(min) + " ");
  }
}

Console.WriteLine(String.Join(' ', array));using static Library.Shared;

Author();

// Напишите метод, который задаёт массив из N элементов и выводит их на экран.
// Создать массив
//  double[] CreateArray(int size){...} +  v

// Заполнить массив руками
//  void Fill(double[] array) + 
//  double[] FillArray(double[] source)

// Распечатать массив
//  void PrintToConsole (double[] array) + 
//  string ArrayJoinToString (double[] array) v

// Считать данные от пользователя
//  double GetDataFromUser (string text) v

// Считать данные от пользователя с целыми числами
//  int GetIntValueFromUser (string text) v


// int count = GetIntValueFromUser("Количество элементов");
// double[] numbers = CreateArray(count);
// Fill(numbers);
// System.Console.WriteLine(ArrayJoinToString(numbers));



// int[] data = { 1, 2, 3, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 1, 1, 1 };

Console.Write("Введите число: ");
int N = 30;
int m = 10;
int[] array = new int[N];
Random rand = new Random();
Console.WriteLine("Исходный массив:");
for (int i = 0; i < array.Length; i++)
{
  array[i] = rand.Next(-3, m);
}

int min = array.Min();

Console.WriteLine(String.Join(' ', array));

// -5 = 5
//  5 = 5

int[] counter = new int[m + Math.Abs(min)];

for (int i = 0; i < array.Length; i++)
{
  counter[array[i] + Math.Abs(min)]++;
}

// Console.WriteLine(String.Join(' ', counter));

// for (int i = 0; i < counter.Length; i++)
// {
//   if (counter[i] != 0)
//     Console.WriteLine($"{i - Math.Abs(min)} {counter[i]}р");
// }


int k = 0;
for (int i = 0; i < counter.Length; i++)
{
  for (int j = 0; j < counter[i]; j++)
  {
    array[k] = i - Math.Abs(min);
    k++;
    //Console.Write(i - Math.Abs(min) + " ");
  }
}

Console.WriteLine(String.Join(' ', array));