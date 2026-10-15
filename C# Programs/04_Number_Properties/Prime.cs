using System;
public class Prime
{
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
    public static void Main(String[] args)
    {
        Console.Write("Enter the number : ");
        int num=Convert.ToInt32(Console.ReadLine());
        Boolean pr=isPrime(num);
        if(pr) Console.WriteLine("The number "+num+" is a prime number!");
        else Console.WriteLine("The number "+num+" is not a prime number!");
    }
}