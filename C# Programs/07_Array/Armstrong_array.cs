using System;
public class Armstrong_array{
     public static Boolean isArmstrong(int num)
    {
        int temp=num;
        int sum=0;
        while (temp > 0)
        {
            int rem=temp%10;
            sum+=(rem*rem*rem);
            temp/=10;
        }
        if(sum==num) return true;
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
        for(int i=0;i < n;i++)
        {
            if (!isArmstrong(num_array[i]))
            {
                num_array[i]=0;
            }
        }
        Console.Write("The Armstrong numbers in the array : ");
        foreach(int i in num_array)
        {
            if(i!=0) Console.Write(i+" ");
        }

    }
}