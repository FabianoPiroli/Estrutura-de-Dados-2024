using System;
using System.Linq;

class Radix
{
    static void Main()
    {
        int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
        Console.WriteLine("Antes da ordenação:");
        Console.WriteLine(string.Join(", ", arr));
        
        RadixSort(arr);
        
        Console.WriteLine("\nDepois da ordenação:");
        Console.WriteLine(string.Join(", ", arr));
    }

    static void RadixSort(int[] arr)
    {
        int max = arr.Max();
        for (int exp = 1; max / exp > 0; exp *= 10)
        {
            CountingSort(arr, exp);
        }
    }

    static void CountingSort(int[] arr, int exp)
    {
        int n = arr.Length;
        int[] output = new int[n];
        int[] count = new int[10];
        
        for (int i = 0; i < n; i++)
        {
            count[(arr[i] / exp) % 10]++;
        }

        for (int i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];
        }

        for (int i = n - 1; i >= 0; i--)
        {
            int index = (arr[i] / exp) % 10;
            output[count[index] - 1] = arr[i];
            count[index]--;
        }

        for (int i = 0; i < n; i++)
        {
            arr[i] = output[i];
        }
    }
}
