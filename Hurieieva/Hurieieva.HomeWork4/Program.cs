using System;
namespace homework4;
class Program
{
    static void Main(string[] args)
    {

        int resulutl1 = FindLargest(12, 32, 42);
        Console.WriteLine($"Larges value : {resulutl1}");
        Console.WriteLine($"Lowest value : {FindLowest(122, 32, 42)}");
        Console.WriteLine($"Nearest value:  { FindNearest20(15, 12)}");
        int[] arr = { 1, 2, 3, 4, 5 };
        int sum = SumOfArray(arr);
        Console.WriteLine("Sum of array elements: " + sum);

        int[] arr1 = { 8, 2, 3, 4, 5 };
        int sum1 = GetLargerValue(arr1);
        Console.WriteLine("larger value from arraye lements: " + sum1);

        Console.ReadLine();
    }

    #region TASK1
    public static int FindLargest(int num1, int num2, int num3)


    {
        int largest = num1;
        if (num2 > largest)
        {
            largest = num2;
        }
        if (num3 > largest)
        {
            largest = num3;
        }
        return largest;
    }
        #endregion
        #region TASK2 

        public static int FindLowest(int num1, int num2, int num3)
    {
        int lowest = num1;
        if (num2 < lowest)
        {
            lowest = num2;
        }
        if (num3 < lowest)
        {
            lowest = num3;
        }
        return lowest;
    }
    #endregion
    #region TASK3

    public static int FindNearest20(int num1, int num2)
    {
        if (num1 == num2)
        {
            return 0; 
        }

        int diff1 = Math.Abs(20 - num1);
        int diff2 = Math.Abs(20 - num2);

        if (diff1 < diff2)
        {
            return num1;
        }
        else if (diff2 < diff1)
        {
            return num2;
        }
        else 
        {
            return 0; 
        }
    }
    #endregion
    #region TASK4

    public static int SumOfArray(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    #endregion
    #region TASK5
    public static int GetLargerValue(int[] arr)
    {
        int largest = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                largest = arr[i];
            }
        }
        return largest;
    }
    #endregion

}