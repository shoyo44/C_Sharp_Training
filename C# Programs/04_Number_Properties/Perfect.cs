using System;
public class Perfect
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
        Console.Write("Enter the number : ");
        int num=Convert.ToInt32(Console.ReadLine());
        Boolean pr=isPerfect(num);
        if(pr) Console.WriteLine("The number "+num+" is a perfect number!");
        else Console.WriteLine("The number "+num+" is not a perfect number!");
    }
}