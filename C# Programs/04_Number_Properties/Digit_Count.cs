using System;
public class Digit_Count
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the number : ");
        int num=Convert.ToInt32(Console.ReadLine());
        if (num <= 0) Console.WriteLine("Please enter a positive number");
        int count=0;
        int dup=num;
        while (dup > 0)
        {
            count++;
            dup/=10;
        }
        Console.WriteLine("The count of the digits in the number "+num+" is "+count);
    }
    
}
