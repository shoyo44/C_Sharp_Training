using System;
public class Spy_Number
{

    public static void Main(String[] args)
    {
        Console.Write("Enter the number : ");
        int num=Convert.ToInt32(Console.ReadLine());
        if (num <= 0) Console.WriteLine("Please enter a positive number");
        int sum=0;
        int product=1;
        int dup=num;
        while (dup > 0)
        {
            int rem=dup%10;
            sum+=rem;
            product*=rem;
            dup/=10;
        }
       

        if(sum==product) Console.WriteLine("The number "+num+" is a spy number");
        else Console.WriteLine("The number "+num+" is not a spy number");
    }
    
}