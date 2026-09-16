using System;

namespace Task2.InputSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.Write("Введите количество элементов: ");
                string? input = Console.ReadLine();
                try
                {
                    n = int.Parse(input ?? "");
                    if (n > 0) break;
                    Console.WriteLine("Ошибка: N должно быть больше 0.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: Число слишком большое!");
                }
            }

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.Write($"Элемент [{i}]: ");
                    string? input = Console.ReadLine();
                    try
                    {
                        array[i] = int.Parse(input ?? "");
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: Введите целое число!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка: Число слишком большое!");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Исходный массив:  " + string.Join(", ", array));

            int[] reversed = new int[n];
            for (int i = 0; i < n; i++)
            {
                reversed[i] = array[n - 1 - i];
            }
            Console.WriteLine("Обратный порядок: " + string.Join(", ", reversed));

            int[] sorted = (int[])array.Clone();
            Array.Sort(sorted);
            Console.WriteLine("Отсортированный:  " + string.Join(", ", sorted));

            int max = array[0];
            int min = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }
            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Минимум: {min}");
        }
    }
}