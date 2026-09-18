using System;

namespace Task4.Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            // 1. Заполнение массива с обработкой FormatException и OverflowException
            for (int i = 0; i < array.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Введите элемент [{i}]: ");
                    string? input = Console.ReadLine();

                    try
                    {
                        array[i] = int.Parse(input ?? "");
                        break; // успешно — переходим к следующему элементу
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

            // 2. Запрос индекса с обработкой IndexOutOfRangeException
            while (true)
            {
                Console.Write($"Введите индекс для вывода (0-{array.Length - 1}): ");
                string? input = Console.ReadLine();

                try
                {
                    int index = int.Parse(input ?? "");
                    Console.WriteLine($"Элемент [{index}] = {array[index]}");
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
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Ошибка: Индекс вне границ массива.");
                }
            }
        }
    }
}