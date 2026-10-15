using System;
public class First1
{
    public static void Main(String[] args)
    {
        Console.Write("Enter your marks : ");
        int mark=Convert.ToInt32(Console.ReadLine());
        if (mark > 90)
        {
            Console.WriteLine("Congratulations you have 50% scholarship");
        }
        else
        {
            Console.WriteLine("Sorry you are not eligible for scholarship");
        }
    }
}