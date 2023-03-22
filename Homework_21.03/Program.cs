using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        string[] array = { "hello", "2", "world", ":-)" };
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                count++;
            }
        }

        int j = 0;
        string[] result = new string[count];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                result[j] += array[i];
                j++;
            }
        }

        WriteLine("Заданный массив:");
        WriteLine(String.Join("+", array));
        WriteLine();
        WriteLine("Массив из строк, длина которых <= 3:");
        WriteLine(String.Join("+", result));
    }
}
