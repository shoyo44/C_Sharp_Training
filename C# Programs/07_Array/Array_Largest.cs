using System;
using System.Numerics;
public class Array_Largest
{
    public static int find_largest(int[] arr,int n)
    {
        int temp=int.MinValue;
        for(int i = 0; i < n; i++)
        {
            if(arr[i]>temp) temp=arr[i];
        }
        return temp;
    }
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
        if(num_array.Length<2) Console.WriteLine("Array Length should be greater than 1");
        int first_max=find_largest(num_array,n);
        for(int i=0;i<n;i++)
        {
            if(num_array[i]==first_max) num_array[i]=int.MinValue;
        }
        int second_largest=find_largest(num_array,n);
        Console.WriteLine("The second largest element in the array is : "+second_largest);
    }
}