using System;
using System.ComponentModel;
public class Incre{
    public static void Main(String[] args)
    {
        Console.Write("Enter your name : ");
        String name=Console.ReadLine();
        Console.Write("Enter your salary : ");
        int salary=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your experience : ");
        int year=Convert.ToInt32(Console.ReadLine());
        if (year <= 1)
        {
            Console.WriteLine("Your Incremented Salary is : "+(int)salary+salary*0.02);
        }
        else if(year>1 && year <= 3)
        {
            Console.WriteLine("Your Incremented Salary is : "+(int)salary+salary*0.05);
        }
        else
        {
            Console.WriteLine("Your Incremented Salary is : "+(int)salary+salary*0.1);
        }
    }
}