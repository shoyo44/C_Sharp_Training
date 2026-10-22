using System;
public class Array_Order
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
        Console.Write("The ascending order of the elements are : ");
        Array.Sort(num_array);
        foreach(int i in num_array) Console.Write(i+" ");
        Console.WriteLine();
        Console.Write("The descending order of the elements are : ");
        Array.Reverse(num_array);
        foreach(int i in num_array) Console.Write(i+" ");
    }
}