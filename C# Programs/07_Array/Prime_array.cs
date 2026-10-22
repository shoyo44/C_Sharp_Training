using System;
public class Prime_array{
     public static Boolean isPrime(int num)
    {
        if(num==1 || num== 2)
        {
            return true;
        }
        for(int i = 2; i <= Math.Sqrt(num); i++)
        {
            if(num%i== 0) return false;
            
        }
        return true;
        
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
        for(int i=0;i < n;i++)
        {
            if (!isPrime(num_array[i]))
            {
                num_array[i]=0;
            }
        }
        Console.Write("The prime numbers in the array : ");
        foreach(int i in num_array)
        {
            if(i!=0) Console.Write(i+" ");
        }

    }
}