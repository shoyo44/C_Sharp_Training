using System;
public class Interview
{
    public static void Main(String[] args)
    {
        Console.Write("Enter your aptitude score : ");
        int apti=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your technical score : ");
        int tech=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your HR score : ");
        int hr=Convert.ToInt32(Console.ReadLine());
        if (apti >= 70)
        {
            if (tech >= 80)
            {
                if(hr >= 80)
                {
                    Console.WriteLine("You are placed");
                    int total=apti+tech+hr; 
                    if(total>280 && total <= 300) Console.WriteLine("Salary : 25000");
                    else if(total>250 && total <= 280) Console.WriteLine("Salary : 20000");
                    else Console.WriteLine("Salary : 15000");
                }
                else Console.WriteLine("You are not placed");
            }
            else Console.WriteLine("You are not placed");
        }
        else Console.WriteLine("You are not placed");
    }
}