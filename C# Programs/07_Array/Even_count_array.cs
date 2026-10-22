using System;
public class Even_count_array{
     public static Boolean isEven(int num)
    {
        if(num%2==0) return true;
        return false;
        
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
        int count =0;
        for(int i=0;i < n;i++)
        {
            if (isEven(num_array[i]))
            {
                count++;
            }
        }
        Console.Write("The even number count in the array : "+count);

    }
}