using System;
public class Neon_Number
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the number : ");
        int num=Convert.ToInt32(Console.ReadLine());
        if (num <= 0) Console.WriteLine("Please enter a positive number");
        int sum=0;
        int dup=num*num;
        while (dup > 0)
        {
            int rem=dup%10;
            sum+=rem;
            dup/=10;
        }

        if(sum==num) Console.WriteLine("The number "+num+" is a Neon number");
        else Console.WriteLine("The number "+num+" is not a Neon number");
    }
    
}
