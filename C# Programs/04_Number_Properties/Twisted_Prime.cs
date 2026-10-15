using System;
public class Twisted_Prime
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
    public static int rev(int num)
    {
        String rev="";
        int temp=num;
        while (temp > 0)
        {
            int rem=temp%10;
            rev+=rem;
            temp/=10;
        }
        int ans=Convert.ToInt32(rev);
        return ans;
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the number : ");
        int num=Convert.ToInt32(Console.ReadLine());
        int reverse=rev(num);
        if(isPrime(reverse)) Console.WriteLine("The number "+num+" is a twisted prime number");
        else Console.WriteLine("The number "+num+" is not a twisted prime number");
    }
}