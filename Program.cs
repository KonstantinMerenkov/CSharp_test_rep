// See https://aka.ms/new-console-template for more information
using System;

public class ArrayMethods
{
    

    public static void Main(string[] args)
    {
        int[] array = GenerateArray(5);
        Console.WriteLine("Массив: ");
        PrintArray(array);
        Console.WriteLine("Перевернутый массив: ");
        PrintArray(GetReverseArr(array));
    }

    public static int[] GenerateArray(int size)
    {
        Random ran = new Random();
        int[] resultArr = new int[size];
        for (int i = 0; i < size; i++)
        {
            resultArr[i] = ran.Next(100);
        }
        return resultArr;
    }

    public static int[] GetReverseArr(int[] arr)
    {
        int[] GetReverseArr = new int[arr.Length];
        int j = arr.Length;
        for (int i = 0; i < arr.Length; i++)
        {
            j--;
            GetReverseArr[j] = arr[i];

        }
        return GetReverseArr;
    }

    public static void PrintArray(int[] arr)
    {
        Console.WriteLine($"{string.Join("\t",arr)}");
    }
}