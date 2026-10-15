using System;
public class Fact
{
    public static int facto(int num)
    {
        if (num <= 0)
            return 1;
        return num*facto(num-1);
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the number to find factorial : ");
        int num=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The factorial of the number "+num+" is : "+facto(num));
    }
}