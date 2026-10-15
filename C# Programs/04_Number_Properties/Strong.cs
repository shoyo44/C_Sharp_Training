using System;
public class Strong
{
    public static int fact(int num)
    {
        if(num==1||num==0) return 1;
        return num*fact(num-1);
    }

    public static void Main(String[] args)
    {
        Console.Write("Enter the number : ");
        int num=Convert.ToInt32(Console.ReadLine());
        if (num <= 0) Console.WriteLine("Please enter a positive number");
        int fact_sum=0;
        int dup=num;
        while (dup > 0)
        {
            int rem=dup%10;
            fact_sum+=fact(rem);
            dup/=10;
        }

        if(fact_sum==num) Console.WriteLine("The number "+num+" is a strong number");
        else Console.WriteLine("The number "+num+" is not a strong number");
    }
    
}