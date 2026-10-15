using System;
public class List_Perfect
{
    public static Boolean isPerfect(int num)
    {
        if(num==1 || num== 2)
        {
            return true;
        }
        int sum=0;
        for(int i = 1; i < num; i++)
        {
            if(num%i== 0) sum+=i;
        }
        if(sum==num) return true;
        return false;
        
    }
    public static void Main(String[] args)
    {
        Console.Write("Perfect numbers between 1 to 100 : ");
        for(int i = 1; i <= 100; i++)
        {
            if(isPerfect(i)) Console.Write(i+" ");
        }
        

    }
}