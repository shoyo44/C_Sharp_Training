using System;
public class Array_Equal
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
        Console.Write("The elements in the original array : ");
        foreach(int i in num_array) Console.Write(i+" ");
        int[] copy_array=new int[n];
        Array.Copy(num_array,copy_array,n);
        Console.WriteLine();
        Console.Write("The elements in the copied array : ");
        foreach(int i in copy_array) Console.Write(i+" ");
        Console.WriteLine();
        if(num_array.SequenceEqual(copy_array)) Console.WriteLine("Both arrays are equal");
        else Console.WriteLine("Both arrays are not equal");
    }
}