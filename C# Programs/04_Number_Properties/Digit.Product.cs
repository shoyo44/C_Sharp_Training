using System;
public class Digit_Product
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the number : ");
        int num=Convert.ToInt32(Console.ReadLine());
        if (num <= 0) Console.WriteLine("Please enter a positive number");
        int product=1;
        int dup=num;
        while (dup > 0)
        {
            int rem=dup%10;
            product*=rem;
            dup/=10;
        }
        Console.WriteLine("The product of the digit "+num+" is "+product);
    }
    
}
