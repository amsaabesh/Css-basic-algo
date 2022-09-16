using System;

namespace Insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, val, flag;
            Console.WriteLine("Number of array?");
            n = Convert.ToInt32(Console.ReadLine());//convert string to number
            int[] arr = new int[n];//array size
            Console.WriteLine("Enter Numbers");
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine()); //insert array
            }
            for (i = 1; i < n; i++) //sorting
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)//main algorithm
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.WriteLine("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}