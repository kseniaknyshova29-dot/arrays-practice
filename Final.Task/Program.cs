using System;

namespace Final.Task
{
    internal class Program
    {
        // Вариант 2 — Палиндром
        static void Main(string[] args)
        {
            Console.Write("Введите массив (числа через пробел): ");
            string? input = Console.ReadLine();

            string[] parts = (input ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = int.Parse(parts[i]);
            }

            bool isPalindrome = true;
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine(isPalindrome ? "Массив — палиндром" : "Массив — не палиндром");
        }
    }
}