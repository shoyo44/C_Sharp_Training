using System;
using System.Net;
using System.Threading.Tasks.Dataflow;
public class Times
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the start value : ");
        int start=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the End Value : ");
        int end=Convert.ToInt32(Console.ReadLine());
        int count=0;
        int sum=0;
        if(start<end){
        for(int i = start; i <=end; i++)
            {
                count++;
                sum+=i;
            }
            Console.WriteLine("Count : "+count+" ,Sum : "+sum);
            
        }
        else{ 
        for(int i = start; i >= end; i--)
            {
                count++;
                sum+=i;
            }
            Console.WriteLine("Count : "+count+" ,Sum : "+sum);
        }
        for(int i = 1; i <= 10; i++)
        {
            if(i%2==0) Console.Write(i+" ");
        }
        Console.WriteLine();
        for(int i = 1; i <= 20; i++)
        {
            if(i%5==0  && i%3==0) Console.Write("FizzBus"+((i<20)?(" "):("")));
            else if(i%3==0) Console.Write("Buzz"+((i<20)?(" "):("")));
            else if(i%5==0) Console.Write("Fizz"+((i<20)?(" "):("")));
            else Console.Write(i+((i<20)?(" "):("")));
        }
        Console.WriteLine();
        int sum1=0;
        for(int i = 100; i <= 150; i++)
        {
            if(i%9==0) sum1+=i;
        }
        Console.WriteLine("Sum : "+sum1);
    
        
    }
}