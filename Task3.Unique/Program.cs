using System;

namespace Task3.Unique
{
    internal class Program
    {
        public static int[] GetUnique(int[] source)
        {
            int[] result = new int[source.Length];
            int count = 0;

            for (int i = 0; i < source.Length; i++)
            {
                bool alreadyExists = false;
                for (int j = 0; j < count; j++)
                {
                    if (result[j] == source[i])
                    {
                        alreadyExists = true;
                        break;
                    }
                }
                if (!alreadyExists)
                {
                    result[count] = source[i];
                    count++;
                }
            }

            int[] trimmed = new int[count];
            for (int i = 0; i < count; i++)
            {
                trimmed[i] = result[i];
            }
            return trimmed;
        }

        static void Main(string[] args)
        {
            int[] source = { 1, 2, 2, 3, 4, 4, 4, 5 };
            int[] unique = GetUnique(source);
            Console.WriteLine("Исходный:   " + string.Join(", ", source));
            Console.WriteLine("Уникальные: " + string.Join(", ", unique));
        }
    }
}