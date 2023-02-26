// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] array = new double[5]; 
double diff = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
    Console.Write($"[{Math.Round(array[i],2)}] ");
}
double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    max = array[i];
     
    if (array[i] < min)
    min = array[i];
}
diff = Math.Round(max,2) - Math.Round(min,2);
Console.WriteLine();
Console.Write($"Разницу между максимальным {Math.Round(max,2)} и минимальным {Math.Round(min,2)} составляет {Math.Round(diff,2)}.");
