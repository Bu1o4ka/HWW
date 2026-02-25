using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkeeeee
{
    internal class Program
    {
        static int FindMiss(int[] a)
        {
            int n = a.Length;
            int expected = n * (n + 1) / 2;
            int dontExpected = 0;

            for (int i = 0; i < n; i++)
            {
                dontExpected += a[i];
            }

            return expected - dontExpected;
        }
        static string FindDuplicate(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        return $"Значение: {arr[i]}, индексы: {i} и {j}";
                    }
                }
            }
            return "Нет повторок";
        }

        static void Main()
        {
            int[] arr =  { 3, 0, 1, 4, 6, 2, 7, 8 };
            Console.WriteLine($"Пропущенное число: {FindMiss(arr)}");

            int[] arr2 = { 1, 4, 6, 6, 9, 12, 15 };
            Console.WriteLine($"Дубль: {FindDuplicate(arr2)}");
        }
    }
}
