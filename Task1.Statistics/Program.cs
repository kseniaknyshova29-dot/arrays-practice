using System;

namespace Task1.Statistics
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Random rnd = new Random();
      int[] numbers = new int[10];
      for (int i = 0; i < numbers.Length; i++)
      {
        numbers[i] = rnd.Next(1, 101);
      }

      Console.WriteLine("Массив: " + string.Join(", ", numbers));

      long sum = 0;
      double product = 1;
      for (int i = 0; i < numbers.Length; i++)
      {
        sum += numbers[i];
        product *= numbers[i];
      }

      int evenCount = 0;
      for (int i = 0; i < numbers.Length; i++)
      {
        if (numbers[i] % 2 == 0) evenCount++;
      }

      double average = (double)sum / numbers.Length;
      int aboveAverage = 0;
      for (int i = 0; i < numbers.Length; i++)
      {
        if (numbers[i] > average) aboveAverage++;
      }

      Console.WriteLine($"Сумма: {sum}");
      Console.WriteLine($"Произведение: {product:E2}");
      Console.WriteLine($"Чётных чисел: {evenCount}");
      Console.WriteLine($"Больше среднего ({average:F1}): {aboveAverage}");
    }
  }
}