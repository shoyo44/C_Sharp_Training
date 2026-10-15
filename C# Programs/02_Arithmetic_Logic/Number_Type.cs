using System;
public class Number_Tupe
{
    public static Boolean isNotPrime(int num)
    {
        if(num==1 || num== 2)
        {
            return false;
        }
        for(int i = 2; i <= Math.Sqrt(num); i++)
        {
            if(num%i== 0) return true;
            
        }
        return false;
        
    }
    public static String num_type(int num)
    {
        int sum=0;
        for(int i = 1; i < num; i++)
        {
            if(num%i== 0) sum+=i;
        }
        
        if (sum > num) Console.Write("The number "+num+" is a abundant number");
        else if(sum<num) Console.Write("The number"+num+" is a deficient number");
        else if(isNotPrime(num)) Console.Write("The number is a composite number");
        return "Please enter a valid number";
        
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the number : ");
        int num=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num_type(num));
    }
}
