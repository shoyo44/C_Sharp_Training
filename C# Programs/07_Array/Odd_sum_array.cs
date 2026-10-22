using System;
public class Odd_sum_array{
     public static int total_sum(int[] arr)
    {
        int sum=0;
        foreach(int num in arr)
        {
            if(num%2==1) sum+=num;
        }
        return sum;
        
    }
    public static void Main(String[] args){
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
        int total=total_sum(num_array);
        Console.Write("The even number count in the array : "+total);

    }
}