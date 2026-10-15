using System;
public class List_Fact
{
    public static int isfact(int num)
    {
        if (num <= 0)
            return 1;
        return num*isfact(num-1);
    }
    public static void Main(String[] args)
    {
        Console.Write("Factorial of numbers between 1 to 10 : ");
        for(int i = 1; i <= 10; i++)
        {
             Console.Write(isfact(i)+" ");
        }
        

    }
}