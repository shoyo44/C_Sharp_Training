using System;
public class Array_K_large
{
    public static int find_small(int[] arr,int n,int k)
    {
        if(k>n) return 0;
        Array.Sort(arr);
        return arr[k];
    }
    public static int find_large(int[] arr,int n,int k)
    {
        if(k>n) return 0;
        Array.Sort(arr);
        Array.Reverse(arr);
        return arr[k];
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
        Console.Write("Enter the kth number to find smallest and largest number in array : ");
        int k_val=Convert.ToInt32(Console.ReadLine());
        int small_val=find_small(num_array,n,(k_val-1));
        int large_val=find_large(num_array,n,(k_val-1));
        if(small_val==0 && large_val==0) Console.WriteLine("Please provide the kth value less than the length of the array");
        else
        {
            Console.WriteLine("The kth smallest value with the posistion "+k_val+" is : "+small_val);
            Console.WriteLine("The kth smallest value with the posistion "+k_val+" is : "+large_val);
        }

    
    }
}