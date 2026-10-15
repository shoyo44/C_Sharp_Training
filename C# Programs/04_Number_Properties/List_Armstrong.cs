using System;
public class List_Armstrong
{
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
    public static void Main(String[] args)
    {
        Console.Write("The Armstrong numbers between 100 to 2000 : ");
        for(int i = 100; i <= 2000; i++)
        {
            if(isArmstrong(i)) Console.Write(i+" ");
        }
        
    }
}