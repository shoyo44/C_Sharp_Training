using System;
public class List_Prime
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
        Console.Write("The Prime numbers between 1 to 100 : ");
        for(int i = 1; i <= 100; i++)
        {
            if(isPrime(i)) Console.Write(i+" ");
        }
        
    }
}