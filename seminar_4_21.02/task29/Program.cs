
        // Задача 29: Напишите метод, который задаёт массив из N элементов 
        // и выводит их на экран.
        // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
        // 6, 1, 33 -> [6, 1, 33]
        
int elementArray = 8;
int[] myArray = new int[elementArray];        
for (int i = 0; i < myArray.Length; i++)
{
   Console.Write($"Введите элемент массива под индексом {i}: ");
   myArray[i] = int.Parse(Console.ReadLine());
}
Console.Write($"Вывод массива: ");       
Console.Write($"[{string.Join(",", myArray)}]"); 