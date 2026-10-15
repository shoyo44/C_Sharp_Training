using System;
using System.Diagnostics.CodeAnalysis;
public class Palindrome
{
    public static Boolean isPal(int num)
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
        if(ans==num) return true;
        return false;
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the number : ");
        int num=Convert.ToInt32(Console.ReadLine());
        if(isPal(num)) Console.WriteLine("The number "+num+" is a palindrome");
        else Console.WriteLine("The number "+num+" is not a palindrome");
        
    }
}