using System;
using System.Dynamic;
using System.Numerics;
public class Array_Frequency
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the size of the array : ");
        int n=Convert.ToInt32(Console.ReadLine());
        int[] num_array=new int[n];
        Console.WriteLine("Enter the elements of the array");
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter the element "+(i+1)+" : ");
            num_array[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("The elements in the array : ");
        foreach(int i in num_array) Console.Write(i+" ");
        Console.WriteLine();
        HashSet<int> set=new HashSet<int>();
        foreach(int i in num_array) set.Add(i);
        int[] unique_array=set.ToArray();
        Array.Sort(num_array);
        Array.Sort(unique_array);
        int[] count_array=new int[unique_array.Length];
        int idx=0;
        foreach(int num in unique_array)
        {
            int count=0;
            foreach(int i in num_array)
            {
                if (num == i)
                {
                    count++;
                }
            }
            count_array[idx]=count;
            idx++;
        }
        Console.WriteLine("The frequency count of elements of the array");
        for(int i=0;i<unique_array.Length;i++) Console.WriteLine("Element "+unique_array[i]+",Frequency : "+count_array[i]);
    }
}